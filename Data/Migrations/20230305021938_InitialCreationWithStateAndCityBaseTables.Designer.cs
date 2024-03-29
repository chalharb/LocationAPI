﻿// <auto-generated />
using System;
using LocationAPI.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocationAPI.Migrations
{
    [DbContext(typeof(LocationDbContext))]
    [Migration("20230305021938_InitialCreationWithStateAndCityBaseTables")]
    partial class InitialCreationWithStateAndCityBaseTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("LocationAPI.Persistence.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("StateId")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("StateId1")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("StateId1");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("LocationAPI.Persistence.Entities.State", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            Id = new Guid("79d9a3ff-5b0c-4b7c-bdde-8d22cd48881d"),
                            Abbreviation = "TN",
                            Name = "Tennessee"
                        },
                        new
                        {
                            Id = new Guid("ebb64e7e-70aa-4fd2-8996-951d396e6d3a"),
                            Abbreviation = "CA",
                            Name = "California"
                        },
                        new
                        {
                            Id = new Guid("052cbff5-2e85-4e23-a344-8cf6ee7e413d"),
                            Abbreviation = "AK",
                            Name = "Alaska"
                        });
                });

            modelBuilder.Entity("LocationAPI.Persistence.Entities.City", b =>
                {
                    b.HasOne("LocationAPI.Persistence.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId1");

                    b.Navigation("State");
                });
#pragma warning restore 612, 618
        }
    }
}
