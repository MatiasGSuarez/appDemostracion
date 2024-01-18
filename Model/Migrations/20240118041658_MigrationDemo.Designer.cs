﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(DbModelContext))]
    [Migration("20240118041658_MigrationDemo")]
    partial class MigrationDemo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Model.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Creation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Delete")
                        .HasColumnType("datetime2");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "All Boys",
                            Age = 16,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9904),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 1",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 1",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            Address = "All Boys",
                            Age = 17,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9929),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 2",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 2",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            Address = "All Boys",
                            Age = 18,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9932),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 3",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 3",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4L,
                            Address = "All Boys",
                            Age = 19,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9934),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 4",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 4",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5L,
                            Address = "All Boys",
                            Age = 20,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9936),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 5",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 5",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6L,
                            Address = "All Boys",
                            Age = 21,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9940),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 6",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 6",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7L,
                            Address = "All Boys",
                            Age = 22,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9942),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 7",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 7",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8L,
                            Address = "All Boys",
                            Age = 23,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9943),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 8",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 8",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9L,
                            Address = "All Boys",
                            Age = 24,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9945),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 9",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 9",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10L,
                            Address = "All Boys",
                            Age = 25,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9948),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 10",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 10",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11L,
                            Address = "All Boys",
                            Age = 26,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9950),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 11",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 11",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12L,
                            Address = "All Boys",
                            Age = 27,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9951),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 12",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 12",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 13L,
                            Address = "All Boys",
                            Age = 28,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9953),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 13",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 13",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 14L,
                            Address = "All Boys",
                            Age = 29,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9954),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 14",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 14",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 15L,
                            Address = "All Boys",
                            Age = 30,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9955),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 15",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 15",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 16L,
                            Address = "All Boys",
                            Age = 31,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9957),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 16",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 16",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 17L,
                            Address = "All Boys",
                            Age = 32,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9958),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 17",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 17",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 18L,
                            Address = "All Boys",
                            Age = 33,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9960),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 18",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 18",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 19L,
                            Address = "All Boys",
                            Age = 34,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9962),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 19",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 19",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 20L,
                            Address = "All Boys",
                            Age = 35,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9963),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 20",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 20",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 21L,
                            Address = "All Boys",
                            Age = 36,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9965),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 21",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 21",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 22L,
                            Address = "All Boys",
                            Age = 37,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9967),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 22",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 22",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 23L,
                            Address = "All Boys",
                            Age = 38,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9968),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 23",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 23",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 24L,
                            Address = "All Boys",
                            Age = 39,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9969),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 24",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 24",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 25L,
                            Address = "All Boys",
                            Age = 40,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9971),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 25",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 25",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 26L,
                            Address = "All Boys",
                            Age = 41,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9972),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 26",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 26",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 27L,
                            Address = "All Boys",
                            Age = 42,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9974),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 27",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 27",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 28L,
                            Address = "All Boys",
                            Age = 43,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9975),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 28",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 28",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 29L,
                            Address = "All Boys",
                            Age = 44,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9977),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 29",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 29",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 30L,
                            Address = "All Boys",
                            Age = 45,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9978),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 30",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 30",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 31L,
                            Address = "All Boys",
                            Age = 46,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9980),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 31",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 31",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 32L,
                            Address = "All Boys",
                            Age = 47,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9981),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 32",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 32",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 33L,
                            Address = "All Boys",
                            Age = 48,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9983),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 33",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 33",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 34L,
                            Address = "All Boys",
                            Age = 49,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9988),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 34",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 34",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 35L,
                            Address = "All Boys",
                            Age = 50,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9990),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 35",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 35",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 36L,
                            Address = "All Boys",
                            Age = 51,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9991),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 36",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 36",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 37L,
                            Address = "All Boys",
                            Age = 52,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9992),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 37",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 37",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 38L,
                            Address = "All Boys",
                            Age = 53,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9994),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 38",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 38",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 39L,
                            Address = "All Boys",
                            Age = 54,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9995),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 39",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 39",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 40L,
                            Address = "All Boys",
                            Age = 55,
                            Creation = new DateTime(2024, 1, 17, 22, 16, 57, 949, DateTimeKind.Local).AddTicks(9997),
                            Delete = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DocumentNumber = "41016905",
                            Name = "Customer 40",
                            PhoneNumber = "3644680649",
                            Surname = "Customer 40",
                            Update = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}