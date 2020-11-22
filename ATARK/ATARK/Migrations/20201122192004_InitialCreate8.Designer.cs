﻿// <auto-generated />
using System;
using ATARK.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ATARK.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201122192004_InitialCreate8")]
    partial class InitialCreate8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ATARK.Models.Entity.ClosedWaterSupplyInstallation", b =>
                {
                    b.Property<int>("ClosedWaterSupplyInstallationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<int>("StateOfTheSystemId")
                        .HasColumnType("int");

                    b.HasKey("ClosedWaterSupplyInstallationId");

                    b.HasIndex("OrganizationId");

                    b.HasIndex("StateOfTheSystemId")
                        .IsUnique();

                    b.ToTable("ClosedWaterSupplyInstallations");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Fish", b =>
                {
                    b.Property<int>("FishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adulthood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("KindOfFishId")
                        .HasColumnType("int");

                    b.Property<int>("PoolNowId")
                        .HasColumnType("int");

                    b.Property<int>("RelocationPoolId")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("FishId");

                    b.HasIndex("KindOfFishId");

                    b.HasIndex("PoolNowId");

                    b.HasIndex("RelocationPoolId");

                    b.ToTable("Fishs");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Herd", b =>
                {
                    b.Property<int>("HerdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<float>("AverageWeightOfAnIndividual")
                        .HasColumnType("real");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("KindOfFishId")
                        .HasColumnType("int");

                    b.Property<int?>("PoolId")
                        .HasColumnType("int");

                    b.Property<int>("PoolIdNow")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("HerdId");

                    b.HasIndex("KindOfFishId");

                    b.HasIndex("PoolId");

                    b.ToTable("Herds");
                });

            modelBuilder.Entity("ATARK.Models.Entity.KindOfFish", b =>
                {
                    b.Property<int>("KindOfFishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Kind")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KindOfFishId");

                    b.ToTable("KindsOfFishs");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Milking", b =>
                {
                    b.Property<int>("MilkingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CaviarWeight")
                        .HasColumnType("int");

                    b.Property<int>("FishId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MilkingDate")
                        .HasColumnType("datetime2");

                    b.HasKey("MilkingId");

                    b.HasIndex("FishId");

                    b.ToTable("Milkings");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Organization", b =>
                {
                    b.Property<int>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FoundationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Pool", b =>
                {
                    b.Property<int>("PoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ClosedWaterSupplyInstallationId")
                        .HasColumnType("int");

                    b.Property<float>("Volume")
                        .HasColumnType("real");

                    b.Property<string>("WhoIsInThePool")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PoolId");

                    b.HasIndex("ClosedWaterSupplyInstallationId");

                    b.ToTable("Pools");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Pregnancy", b =>
                {
                    b.Property<int>("PregnancyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FishId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateOfPregnancy")
                        .HasColumnType("datetime2");

                    b.HasKey("PregnancyId");

                    b.HasIndex("FishId");

                    b.ToTable("Pregnancys");
                });

            modelBuilder.Entity("ATARK.Models.Entity.StateOfTheSystem", b =>
                {
                    b.Property<int>("StateOfTheSystemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateOfLastCheck")
                        .HasColumnType("datetime2");

                    b.Property<float>("OxygenLevel")
                        .HasColumnType("real");

                    b.Property<float>("Temperature")
                        .HasColumnType("real");

                    b.HasKey("StateOfTheSystemId");

                    b.ToTable("StatesOfSystems");
                });

            modelBuilder.Entity("ATARK.Models.Entity.ClosedWaterSupplyInstallation", b =>
                {
                    b.HasOne("ATARK.Models.Entity.Organization", "Organization")
                        .WithMany("ClosedWaterSupplyInstallations")
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ATARK.Models.Entity.StateOfTheSystem", "StateOfTheSystem")
                        .WithOne("ClosedWaterSupplyInstallation")
                        .HasForeignKey("ATARK.Models.Entity.ClosedWaterSupplyInstallation", "StateOfTheSystemId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Organization");

                    b.Navigation("StateOfTheSystem");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Fish", b =>
                {
                    b.HasOne("ATARK.Models.Entity.KindOfFish", "KindOfFish")
                        .WithMany("Fishs")
                        .HasForeignKey("KindOfFishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ATARK.Models.Entity.Pool", "PoolNow")
                        .WithMany("FishsNow")
                        .HasForeignKey("PoolNowId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ATARK.Models.Entity.Pool", "RelocationPool")
                        .WithMany("RelocationFishs")
                        .HasForeignKey("RelocationPoolId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("KindOfFish");

                    b.Navigation("PoolNow");

                    b.Navigation("RelocationPool");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Herd", b =>
                {
                    b.HasOne("ATARK.Models.Entity.KindOfFish", "KindOfFish")
                        .WithMany("Herds")
                        .HasForeignKey("KindOfFishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ATARK.Models.Entity.Pool", "Pool")
                        .WithMany("Herds")
                        .HasForeignKey("PoolId");

                    b.Navigation("KindOfFish");

                    b.Navigation("Pool");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Milking", b =>
                {
                    b.HasOne("ATARK.Models.Entity.Fish", "Fish")
                        .WithMany("Milkings")
                        .HasForeignKey("FishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fish");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Pool", b =>
                {
                    b.HasOne("ATARK.Models.Entity.ClosedWaterSupplyInstallation", "ClosedWaterSupplyInstallation")
                        .WithMany("Pools")
                        .HasForeignKey("ClosedWaterSupplyInstallationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClosedWaterSupplyInstallation");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Pregnancy", b =>
                {
                    b.HasOne("ATARK.Models.Entity.Fish", "Fish")
                        .WithMany("Pregnancys")
                        .HasForeignKey("FishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fish");
                });

            modelBuilder.Entity("ATARK.Models.Entity.ClosedWaterSupplyInstallation", b =>
                {
                    b.Navigation("Pools");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Fish", b =>
                {
                    b.Navigation("Milkings");

                    b.Navigation("Pregnancys");
                });

            modelBuilder.Entity("ATARK.Models.Entity.KindOfFish", b =>
                {
                    b.Navigation("Fishs");

                    b.Navigation("Herds");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Organization", b =>
                {
                    b.Navigation("ClosedWaterSupplyInstallations");
                });

            modelBuilder.Entity("ATARK.Models.Entity.Pool", b =>
                {
                    b.Navigation("FishsNow");

                    b.Navigation("Herds");

                    b.Navigation("RelocationFishs");
                });

            modelBuilder.Entity("ATARK.Models.Entity.StateOfTheSystem", b =>
                {
                    b.Navigation("ClosedWaterSupplyInstallation");
                });
#pragma warning restore 612, 618
        }
    }
}
