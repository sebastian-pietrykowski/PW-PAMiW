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
    [Migration("20231202202246_addUser")]
    partial class addUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P06Shop.Shared.Auth.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryOfOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

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

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("LengthInMinutes")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReviewId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryOfOrigin = "Dania",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Director = "Władysław Stępień",
                            LengthInMinutes = 211,
                            ReleaseDate = new DateTime(2009, 4, 29, 5, 42, 44, 143, DateTimeKind.Local).AddTicks(5387),
                            Title = "Ergonomic Steel Pants"
                        },
                        new
                        {
                            Id = 2,
                            CountryOfOrigin = "Kiribati",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Director = "Jakub Nowaczyk",
                            LengthInMinutes = 115,
                            ReleaseDate = new DateTime(2009, 3, 21, 21, 34, 49, 465, DateTimeKind.Local).AddTicks(7509),
                            Title = "Intelligent Metal Chips"
                        },
                        new
                        {
                            Id = 3,
                            CountryOfOrigin = "Gujana",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Director = "Regina Robak",
                            LengthInMinutes = 156,
                            ReleaseDate = new DateTime(1994, 4, 3, 17, 10, 42, 478, DateTimeKind.Local).AddTicks(6776),
                            Title = "Rustic Rubber Sausages"
                        },
                        new
                        {
                            Id = 4,
                            CountryOfOrigin = "Trynidad i Tobago",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Director = "Łazarz Pawlikowski",
                            LengthInMinutes = 209,
                            ReleaseDate = new DateTime(2000, 9, 18, 5, 13, 39, 735, DateTimeKind.Local).AddTicks(3066),
                            Title = "Fantastic Wooden Chips"
                        },
                        new
                        {
                            Id = 5,
                            CountryOfOrigin = "Republika Środkowoafrykańska",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Director = "Wawrzyniec Szczepański",
                            LengthInMinutes = 220,
                            ReleaseDate = new DateTime(2003, 1, 13, 22, 59, 44, 322, DateTimeKind.Local).AddTicks(348),
                            Title = "Tasty Fresh Chips"
                        },
                        new
                        {
                            Id = 6,
                            CountryOfOrigin = "Liberia",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Director = "Laura Cygan",
                            LengthInMinutes = 102,
                            ReleaseDate = new DateTime(2015, 10, 30, 10, 2, 46, 633, DateTimeKind.Local).AddTicks(2396),
                            Title = "Incredible Cotton Keyboard"
                        },
                        new
                        {
                            Id = 7,
                            CountryOfOrigin = "Kenia",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Director = "Józef Broda",
                            LengthInMinutes = 171,
                            ReleaseDate = new DateTime(2004, 1, 31, 14, 18, 28, 599, DateTimeKind.Local).AddTicks(7921),
                            Title = "Small Wooden Shirt"
                        },
                        new
                        {
                            Id = 8,
                            CountryOfOrigin = "Uganda",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Director = "Marceli Żurek",
                            LengthInMinutes = 88,
                            ReleaseDate = new DateTime(2021, 9, 22, 15, 56, 9, 457, DateTimeKind.Local).AddTicks(7506),
                            Title = "Handmade Metal Towels"
                        },
                        new
                        {
                            Id = 9,
                            CountryOfOrigin = "Mongolia",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Director = "Cyrus Nowaczyk",
                            LengthInMinutes = 29,
                            ReleaseDate = new DateTime(2000, 10, 1, 16, 53, 6, 659, DateTimeKind.Local).AddTicks(4033),
                            Title = "Refined Soft Tuna"
                        },
                        new
                        {
                            Id = 10,
                            CountryOfOrigin = "Kenia",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Director = "Rajnold Stefaniak",
                            LengthInMinutes = 180,
                            ReleaseDate = new DateTime(1998, 3, 18, 6, 57, 59, 935, DateTimeKind.Local).AddTicks(4456),
                            Title = "Refined Cotton Bacon"
                        },
                        new
                        {
                            Id = 11,
                            CountryOfOrigin = "Nauru",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Director = "Erwin Mroczek",
                            LengthInMinutes = 46,
                            ReleaseDate = new DateTime(1997, 11, 30, 16, 53, 38, 442, DateTimeKind.Local).AddTicks(6718),
                            Title = "Rustic Frozen Sausages"
                        },
                        new
                        {
                            Id = 12,
                            CountryOfOrigin = "Malawi",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Noemi Szczerba",
                            LengthInMinutes = 168,
                            ReleaseDate = new DateTime(2014, 3, 16, 13, 28, 11, 606, DateTimeKind.Local).AddTicks(774),
                            Title = "Unbranded Soft Cheese"
                        },
                        new
                        {
                            Id = 13,
                            CountryOfOrigin = "Bułgaria",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Lilia Zdunek",
                            LengthInMinutes = 104,
                            ReleaseDate = new DateTime(2004, 12, 31, 14, 32, 14, 419, DateTimeKind.Local).AddTicks(8639),
                            Title = "Awesome Concrete Bike"
                        },
                        new
                        {
                            Id = 14,
                            CountryOfOrigin = "Kirgistan",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Fabian Jóźwiak",
                            LengthInMinutes = 99,
                            ReleaseDate = new DateTime(2003, 4, 3, 13, 52, 16, 904, DateTimeKind.Local).AddTicks(3856),
                            Title = "Gorgeous Frozen Salad"
                        },
                        new
                        {
                            Id = 15,
                            CountryOfOrigin = "Portugalia",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Director = "Agata Wesołowski",
                            LengthInMinutes = 134,
                            ReleaseDate = new DateTime(2014, 5, 19, 6, 20, 33, 749, DateTimeKind.Local).AddTicks(4218),
                            Title = "Incredible Concrete Gloves"
                        },
                        new
                        {
                            Id = 16,
                            CountryOfOrigin = "Liban",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Director = "Alan Gwóźdź",
                            LengthInMinutes = 158,
                            ReleaseDate = new DateTime(2017, 3, 1, 14, 46, 16, 250, DateTimeKind.Local).AddTicks(5481),
                            Title = "Awesome Plastic Salad"
                        },
                        new
                        {
                            Id = 17,
                            CountryOfOrigin = "Malezja",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Director = "Eustracjusz Baranowski",
                            LengthInMinutes = 62,
                            ReleaseDate = new DateTime(2007, 8, 5, 0, 42, 28, 886, DateTimeKind.Local).AddTicks(2511),
                            Title = "Rustic Wooden Shirt"
                        },
                        new
                        {
                            Id = 18,
                            CountryOfOrigin = "Armenia",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Director = "Nazariusz Szczepaniak",
                            LengthInMinutes = 239,
                            ReleaseDate = new DateTime(1999, 7, 18, 6, 31, 30, 277, DateTimeKind.Local).AddTicks(7584),
                            Title = "Fantastic Frozen Computer"
                        },
                        new
                        {
                            Id = 19,
                            CountryOfOrigin = "Burkina Faso",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Director = "Hipolit Gadomski",
                            LengthInMinutes = 204,
                            ReleaseDate = new DateTime(2012, 7, 22, 19, 7, 2, 762, DateTimeKind.Local).AddTicks(1229),
                            Title = "Practical Concrete Shoes"
                        },
                        new
                        {
                            Id = 20,
                            CountryOfOrigin = "Wyspy Marshalla",
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Director = "Filemon Falkowski",
                            LengthInMinutes = 159,
                            ReleaseDate = new DateTime(2006, 2, 4, 9, 1, 44, 119, DateTimeKind.Local).AddTicks(189),
                            Title = "Fantastic Plastic Table"
                        },
                        new
                        {
                            Id = 21,
                            CountryOfOrigin = "Francja",
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Director = "Pankracy Ossowski",
                            LengthInMinutes = 189,
                            ReleaseDate = new DateTime(2016, 12, 12, 17, 41, 12, 67, DateTimeKind.Local).AddTicks(4438),
                            Title = "Generic Metal Towels"
                        },
                        new
                        {
                            Id = 22,
                            CountryOfOrigin = "Kongo",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Director = "Jerzy Marchewka",
                            LengthInMinutes = 109,
                            ReleaseDate = new DateTime(2012, 2, 29, 10, 17, 41, 450, DateTimeKind.Local).AddTicks(3459),
                            Title = "Gorgeous Plastic Computer"
                        },
                        new
                        {
                            Id = 23,
                            CountryOfOrigin = "Togo",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Director = "Malwina Wilczyński",
                            LengthInMinutes = 95,
                            ReleaseDate = new DateTime(2018, 10, 16, 1, 14, 47, 312, DateTimeKind.Local).AddTicks(6633),
                            Title = "Intelligent Cotton Bike"
                        },
                        new
                        {
                            Id = 24,
                            CountryOfOrigin = "Boliwia",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Director = "Cyra Kotowski",
                            LengthInMinutes = 194,
                            ReleaseDate = new DateTime(2017, 9, 13, 12, 43, 44, 220, DateTimeKind.Local).AddTicks(2645),
                            Title = "Handcrafted Concrete Bacon"
                        },
                        new
                        {
                            Id = 25,
                            CountryOfOrigin = "Mołdawia",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Director = "Patrycja Kruk",
                            LengthInMinutes = 200,
                            ReleaseDate = new DateTime(1999, 12, 1, 12, 11, 14, 310, DateTimeKind.Local).AddTicks(876),
                            Title = "Rustic Frozen Bike"
                        },
                        new
                        {
                            Id = 26,
                            CountryOfOrigin = "Austria",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Director = "Franciszka Bukowski",
                            LengthInMinutes = 187,
                            ReleaseDate = new DateTime(2006, 1, 5, 11, 50, 21, 751, DateTimeKind.Local).AddTicks(5829),
                            Title = "Awesome Wooden Towels"
                        },
                        new
                        {
                            Id = 27,
                            CountryOfOrigin = "Mongolia",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Director = "Melania Surma",
                            LengthInMinutes = 132,
                            ReleaseDate = new DateTime(1997, 7, 1, 11, 47, 36, 952, DateTimeKind.Local).AddTicks(6283),
                            Title = "Ergonomic Rubber Mouse"
                        },
                        new
                        {
                            Id = 28,
                            CountryOfOrigin = "Zjednoczone Emiraty Arabskie",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Director = "Gerald Tomaszewski",
                            LengthInMinutes = 48,
                            ReleaseDate = new DateTime(2010, 10, 16, 19, 14, 18, 294, DateTimeKind.Local).AddTicks(6),
                            Title = "Incredible Rubber Salad"
                        },
                        new
                        {
                            Id = 29,
                            CountryOfOrigin = "Samoa",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Elżbieta Sołtysiak",
                            LengthInMinutes = 118,
                            ReleaseDate = new DateTime(1997, 8, 2, 15, 45, 34, 274, DateTimeKind.Local).AddTicks(2038),
                            Title = "Generic Frozen Chicken"
                        },
                        new
                        {
                            Id = 30,
                            CountryOfOrigin = "Brunei",
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Director = "Beatrycze Kaczmarek",
                            LengthInMinutes = 194,
                            ReleaseDate = new DateTime(2005, 9, 3, 22, 27, 59, 620, DateTimeKind.Local).AddTicks(1214),
                            Title = "Awesome Concrete Shoes"
                        },
                        new
                        {
                            Id = 31,
                            CountryOfOrigin = "Gwinea Równikowa",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Director = "Ludwik Drozdowski",
                            LengthInMinutes = 29,
                            ReleaseDate = new DateTime(2020, 12, 4, 17, 30, 19, 381, DateTimeKind.Local).AddTicks(2682),
                            Title = "Awesome Wooden Shirt"
                        },
                        new
                        {
                            Id = 32,
                            CountryOfOrigin = "Wenezuela",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Prokop Góral",
                            LengthInMinutes = 208,
                            ReleaseDate = new DateTime(2005, 4, 12, 14, 19, 37, 282, DateTimeKind.Local).AddTicks(9014),
                            Title = "Handcrafted Concrete Chair"
                        },
                        new
                        {
                            Id = 33,
                            CountryOfOrigin = "Nigeria",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Director = "Stella Dudzik",
                            LengthInMinutes = 227,
                            ReleaseDate = new DateTime(2016, 6, 4, 18, 3, 14, 64, DateTimeKind.Local).AddTicks(7160),
                            Title = "Rustic Wooden Chips"
                        },
                        new
                        {
                            Id = 34,
                            CountryOfOrigin = "Argentyna",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Director = "Onufry Dobrowolski",
                            LengthInMinutes = 102,
                            ReleaseDate = new DateTime(2000, 2, 14, 12, 28, 46, 40, DateTimeKind.Local).AddTicks(7342),
                            Title = "Small Wooden Pizza"
                        },
                        new
                        {
                            Id = 35,
                            CountryOfOrigin = "Nikaragua",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Pankracy Balcerzak",
                            LengthInMinutes = 128,
                            ReleaseDate = new DateTime(2006, 8, 13, 10, 43, 27, 511, DateTimeKind.Local).AddTicks(2372),
                            Title = "Incredible Concrete Mouse"
                        });
                });

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.MovieActors", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MovieActors");
                });

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.Review", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewerSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.Movie", b =>
                {
                    b.HasOne("P06Shop.Shared.MovieCollection.Genre", "Genre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreId");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.MovieActors", b =>
                {
                    b.HasOne("P06Shop.Shared.MovieCollection.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P06Shop.Shared.MovieCollection.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.Review", b =>
                {
                    b.HasOne("P06Shop.Shared.MovieCollection.Movie", "Movie")
                        .WithOne("Review")
                        .HasForeignKey("P06Shop.Shared.MovieCollection.Review", "MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.Actor", b =>
                {
                    b.Navigation("MovieActors");
                });

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("P06Shop.Shared.MovieCollection.Movie", b =>
                {
                    b.Navigation("MovieActors");

                    b.Navigation("Review");
                });
#pragma warning restore 612, 618
        }
    }
}
