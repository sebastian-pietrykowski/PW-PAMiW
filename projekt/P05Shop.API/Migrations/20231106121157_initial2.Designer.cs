﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231106121157_initial2")]
    partial class initial2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryOfOrigin")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("LengthInMinutes")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryOfOrigin = "Dania",
                            Director = "Władysław Stępień",
                            Genre = "Tools",
                            LengthInMinutes = 211,
                            ReleaseDate = new DateTime(2009, 4, 2, 21, 31, 55, 530, DateTimeKind.Local).AddTicks(2408),
                            Title = "Gorgeous Wooden Chair"
                        },
                        new
                        {
                            Id = 2,
                            CountryOfOrigin = "Kiribati",
                            Director = "Jakub Nowaczyk",
                            Genre = "Industrial",
                            LengthInMinutes = 115,
                            ReleaseDate = new DateTime(2009, 2, 23, 13, 24, 0, 852, DateTimeKind.Local).AddTicks(4735),
                            Title = "Fantastic Concrete Chicken"
                        },
                        new
                        {
                            Id = 3,
                            CountryOfOrigin = "Gujana",
                            Director = "Regina Robak",
                            Genre = "Automotive",
                            LengthInMinutes = 156,
                            ReleaseDate = new DateTime(1994, 3, 8, 8, 59, 53, 865, DateTimeKind.Local).AddTicks(4538),
                            Title = "Incredible Wooden Towels"
                        },
                        new
                        {
                            Id = 4,
                            CountryOfOrigin = "Trynidad i Tobago",
                            Director = "Łazarz Pawlikowski",
                            Genre = "Industrial",
                            LengthInMinutes = 209,
                            ReleaseDate = new DateTime(2000, 8, 22, 21, 2, 51, 122, DateTimeKind.Local).AddTicks(1412),
                            Title = "Gorgeous Cotton Computer"
                        },
                        new
                        {
                            Id = 5,
                            CountryOfOrigin = "Republika Środkowoafrykańska",
                            Director = "Wawrzyniec Szczepański",
                            Genre = "Industrial",
                            LengthInMinutes = 220,
                            ReleaseDate = new DateTime(2002, 12, 18, 14, 48, 55, 708, DateTimeKind.Local).AddTicks(9140),
                            Title = "Rustic Frozen Bacon"
                        },
                        new
                        {
                            Id = 6,
                            CountryOfOrigin = "Liberia",
                            Director = "Laura Cygan",
                            Genre = "Music",
                            LengthInMinutes = 102,
                            ReleaseDate = new DateTime(2015, 10, 4, 1, 51, 58, 20, DateTimeKind.Local).AddTicks(1919),
                            Title = "Fantastic Plastic Table"
                        },
                        new
                        {
                            Id = 7,
                            CountryOfOrigin = "Kenia",
                            Director = "Józef Broda",
                            Genre = "Grocery",
                            LengthInMinutes = 171,
                            ReleaseDate = new DateTime(2004, 1, 5, 6, 7, 39, 986, DateTimeKind.Local).AddTicks(8138),
                            Title = "Unbranded Steel Computer"
                        },
                        new
                        {
                            Id = 8,
                            CountryOfOrigin = "Uganda",
                            Director = "Marceli Żurek",
                            Genre = "Toys",
                            LengthInMinutes = 88,
                            ReleaseDate = new DateTime(2021, 8, 27, 7, 45, 20, 844, DateTimeKind.Local).AddTicks(8242),
                            Title = "Handmade Metal Chicken"
                        },
                        new
                        {
                            Id = 9,
                            CountryOfOrigin = "Mongolia",
                            Director = "Cyrus Nowaczyk",
                            Genre = "Baby",
                            LengthInMinutes = 29,
                            ReleaseDate = new DateTime(2000, 9, 5, 8, 42, 18, 46, DateTimeKind.Local).AddTicks(5245),
                            Title = "Incredible Fresh Bacon"
                        },
                        new
                        {
                            Id = 10,
                            CountryOfOrigin = "Kenia",
                            Director = "Rajnold Stefaniak",
                            Genre = "Sports",
                            LengthInMinutes = 180,
                            ReleaseDate = new DateTime(1998, 2, 19, 22, 47, 11, 322, DateTimeKind.Local).AddTicks(6145),
                            Title = "Unbranded Fresh Table"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}