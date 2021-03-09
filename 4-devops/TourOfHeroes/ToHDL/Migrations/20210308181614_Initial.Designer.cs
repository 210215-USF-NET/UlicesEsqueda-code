﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ToHDL;

namespace ToHDL.Migrations
{
    [DbContext(typeof(HeroDBContext))]
    [Migration("20210308181614_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("ToHModels.Hero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ElementType")
                        .HasColumnType("integer");

                    b.Property<int>("HP")
                        .HasColumnType("integer");

                    b.Property<string>("HeroName")
                        .HasColumnType("text");

                    b.Property<int?>("SuperPowerId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SuperPowerId");

                    b.ToTable("Heroes");
                });

            modelBuilder.Entity("ToHModels.SuperPower", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Damage")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SuperPowers");
                });

            modelBuilder.Entity("ToHModels.Hero", b =>
                {
                    b.HasOne("ToHModels.SuperPower", "SuperPower")
                        .WithMany()
                        .HasForeignKey("SuperPowerId");

                    b.Navigation("SuperPower");
                });
#pragma warning restore 612, 618
        }
    }
}
