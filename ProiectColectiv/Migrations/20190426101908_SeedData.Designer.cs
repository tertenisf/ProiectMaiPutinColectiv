﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectColectiv.Models;

namespace ProiectColectiv.Migrations
{
    [DbContext(typeof(ProiectColectivContext))]
    [Migration("20190426101908_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProiectColectiv.Models.Parking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Latitudine");

                    b.Property<string>("Longitudine");

                    b.Property<string>("Name");

                    b.Property<int>("NrFastChargingSpots");

                    b.Property<int>("NrNormalChargingSpots");

                    b.HasKey("Id");

                    b.ToTable("Parkings");
                });

            modelBuilder.Entity("ProiectColectiv.Models.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DailyGain");

                    b.Property<bool>("IsFastCharging");

                    b.Property<string>("MonthlyGain");

                    b.Property<int?>("ParkingId");

                    b.Property<string>("PlateNumber");

                    b.Property<string>("WeeklyGain");

                    b.HasKey("Id");

                    b.HasIndex("ParkingId");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("ProiectColectiv.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<bool>("isAdmin");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ProiectColectiv.Models.Station", b =>
                {
                    b.HasOne("ProiectColectiv.Models.Parking")
                        .WithMany("Stations")
                        .HasForeignKey("ParkingId");
                });
#pragma warning restore 612, 618
        }
    }
}
