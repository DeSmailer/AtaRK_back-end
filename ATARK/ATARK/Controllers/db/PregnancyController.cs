﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ATARK.Models.Entity;
using ATARK.Models.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ATARK.Controllers.db
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PregnancyController : ControllerBase
    {
        private readonly IRepository repository;

        public PregnancyController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Pregnancy>> Get()
        {
            var pregnancy = await this.repository.GetRangeAsync<Pregnancy>(true, x => true);
            return pregnancy.ToArray();
        }

        [HttpGet("{pregnancyId}")]
        public async Task<Pregnancy> GetById(int pregnancyId)
        {
            var pregnancy = await this.repository.GetAsync<Pregnancy>(true, x => x.PregnancyId == pregnancyId);
            if (pregnancy == null)
            {
                throw new Exception("Pregnancy not found.");
            }
            return pregnancy;
        }

        [HttpGet("{fishId}")]
        public async Task<IEnumerable<Pregnancy>> GetByFishId(int fishId)
        {
            var pregnancy = await this.repository.GetRangeAsync<Pregnancy>(true, x => x.FishId == fishId);
            if (pregnancy == null)
            {
                throw new Exception("Pregnancy not found.");
            }
            return pregnancy.ToArray();
        }


        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Pregnancy pregnancy)
        {
            var fish = await this.repository.GetAsync<Fish>(true, x => x.FishId == pregnancy.FishId);
            fish.State = "Pregnancy";
            await this.repository.UpdateAsync<Fish>(fish);
            await this.repository.AddAsync<Pregnancy>(pregnancy);

            return this.Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Pregnancy pregnancy)
        {
            var currentPregnancy = await this.repository.GetAsync<Pregnancy>(true, x => x.PregnancyId == pregnancy.PregnancyId);
            if (currentPregnancy == null)
            {
                throw new Exception("Pregnancy not found.");
            }
            currentPregnancy.FishId = pregnancy.FishId;
            currentPregnancy.StartDateOfPregnancy = pregnancy.StartDateOfPregnancy;
            await this.repository.UpdateAsync<Pregnancy>(currentPregnancy);
            return this.Ok();

        }

        [HttpDelete("{pregnancyId}")]
        public async Task<IActionResult> Delete(int pregnancyId)
        {
            var pregnancy = await this.repository.GetAsync<Pregnancy>(true, x => x.PregnancyId == pregnancyId);
            if (pregnancy == null)
            {
                throw new Exception("Pregnancy not found.");
            }
            await this.repository.DeleteAsync<Pregnancy>(pregnancy);
            return this.Ok();
        }
    }
}
