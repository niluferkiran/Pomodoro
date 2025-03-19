﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using myPomodoro.Models;

#nullable disable

namespace myPomodoro.Migrations
{
    [DbContext(typeof(PomodoroContext))]
    [Migration("20250319212159_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("myPomodoro.Models.Sayac", b =>
                {
                    b.Property<int>("PomodoroID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PomodoroID"), 1L, 1);

                    b.Property<bool>("BaslaBitir")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("Sure")
                        .HasColumnType("time");

                    b.Property<int>("Toplam")
                        .HasColumnType("int");

                    b.HasKey("PomodoroID");

                    b.ToTable("Sayaclar");
                });
#pragma warning restore 612, 618
        }
    }
}
