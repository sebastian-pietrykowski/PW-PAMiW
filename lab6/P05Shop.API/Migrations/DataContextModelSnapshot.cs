﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P05Shop.API.Models;

#nullable disable

namespace P05Shop.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            ReleaseDate = new DateTime(2009, 4, 16, 7, 59, 22, 829, DateTimeKind.Local).AddTicks(235),
                            Title = "Ergonomic Steel Pants"
                        },
                        new
                        {
                            Id = 2,
                            CountryOfOrigin = "Kiribati",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Director = "Jakub Nowaczyk",
                            LengthInMinutes = 115,
                            ReleaseDate = new DateTime(2009, 3, 8, 23, 51, 28, 151, DateTimeKind.Local).AddTicks(2160),
                            Title = "Intelligent Metal Chips"
                        },
                        new
                        {
                            Id = 3,
                            CountryOfOrigin = "Gujana",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Director = "Regina Robak",
                            LengthInMinutes = 156,
                            ReleaseDate = new DateTime(1994, 3, 21, 19, 27, 21, 164, DateTimeKind.Local).AddTicks(1394),
                            Title = "Rustic Rubber Sausages"
                        },
                        new
                        {
                            Id = 4,
                            CountryOfOrigin = "Trynidad i Tobago",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Director = "Łazarz Pawlikowski",
                            LengthInMinutes = 209,
                            ReleaseDate = new DateTime(2000, 9, 5, 7, 30, 18, 420, DateTimeKind.Local).AddTicks(7717),
                            Title = "Fantastic Wooden Chips"
                        },
                        new
                        {
                            Id = 5,
                            CountryOfOrigin = "Republika Środkowoafrykańska",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Director = "Wawrzyniec Szczepański",
                            LengthInMinutes = 220,
                            ReleaseDate = new DateTime(2003, 1, 1, 1, 16, 23, 7, DateTimeKind.Local).AddTicks(5014),
                            Title = "Tasty Fresh Chips"
                        },
                        new
                        {
                            Id = 6,
                            CountryOfOrigin = "Liberia",
                            Description = "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design",
                            Director = "Laura Cygan",
                            LengthInMinutes = 102,
                            ReleaseDate = new DateTime(2015, 10, 17, 12, 19, 25, 318, DateTimeKind.Local).AddTicks(7049),
                            Title = "Incredible Cotton Keyboard"
                        },
                        new
                        {
                            Id = 7,
                            CountryOfOrigin = "Kenia",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Director = "Józef Broda",
                            LengthInMinutes = 171,
                            ReleaseDate = new DateTime(2004, 1, 18, 16, 35, 7, 285, DateTimeKind.Local).AddTicks(2525),
                            Title = "Small Wooden Shirt"
                        },
                        new
                        {
                            Id = 8,
                            CountryOfOrigin = "Uganda",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Director = "Marceli Żurek",
                            LengthInMinutes = 88,
                            ReleaseDate = new DateTime(2021, 9, 9, 18, 12, 48, 143, DateTimeKind.Local).AddTicks(2128),
                            Title = "Handmade Metal Towels"
                        },
                        new
                        {
                            Id = 9,
                            CountryOfOrigin = "Mongolia",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Director = "Cyrus Nowaczyk",
                            LengthInMinutes = 29,
                            ReleaseDate = new DateTime(2000, 9, 18, 19, 9, 45, 344, DateTimeKind.Local).AddTicks(8609),
                            Title = "Refined Soft Tuna"
                        },
                        new
                        {
                            Id = 10,
                            CountryOfOrigin = "Kenia",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Director = "Rajnold Stefaniak",
                            LengthInMinutes = 180,
                            ReleaseDate = new DateTime(1998, 3, 5, 9, 14, 38, 620, DateTimeKind.Local).AddTicks(9061),
                            Title = "Refined Cotton Bacon"
                        },
                        new
                        {
                            Id = 11,
                            CountryOfOrigin = "Nauru",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Director = "Erwin Mroczek",
                            LengthInMinutes = 46,
                            ReleaseDate = new DateTime(1997, 11, 17, 19, 10, 17, 128, DateTimeKind.Local).AddTicks(1315),
                            Title = "Rustic Frozen Sausages"
                        },
                        new
                        {
                            Id = 12,
                            CountryOfOrigin = "Malawi",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Noemi Szczerba",
                            LengthInMinutes = 168,
                            ReleaseDate = new DateTime(2014, 3, 3, 15, 44, 50, 291, DateTimeKind.Local).AddTicks(5360),
                            Title = "Unbranded Soft Cheese"
                        },
                        new
                        {
                            Id = 13,
                            CountryOfOrigin = "Bułgaria",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Lilia Zdunek",
                            LengthInMinutes = 104,
                            ReleaseDate = new DateTime(2004, 12, 18, 16, 48, 53, 105, DateTimeKind.Local).AddTicks(3193),
                            Title = "Awesome Concrete Bike"
                        },
                        new
                        {
                            Id = 14,
                            CountryOfOrigin = "Kirgistan",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Fabian Jóźwiak",
                            LengthInMinutes = 99,
                            ReleaseDate = new DateTime(2003, 3, 21, 16, 8, 55, 589, DateTimeKind.Local).AddTicks(8418),
                            Title = "Gorgeous Frozen Salad"
                        },
                        new
                        {
                            Id = 15,
                            CountryOfOrigin = "Portugalia",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Director = "Agata Wesołowski",
                            LengthInMinutes = 134,
                            ReleaseDate = new DateTime(2014, 5, 6, 8, 37, 12, 434, DateTimeKind.Local).AddTicks(8730),
                            Title = "Incredible Concrete Gloves"
                        },
                        new
                        {
                            Id = 16,
                            CountryOfOrigin = "Liban",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Director = "Alan Gwóźdź",
                            LengthInMinutes = 158,
                            ReleaseDate = new DateTime(2017, 2, 16, 17, 2, 54, 935, DateTimeKind.Local).AddTicks(9974),
                            Title = "Awesome Plastic Salad"
                        },
                        new
                        {
                            Id = 17,
                            CountryOfOrigin = "Malezja",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Director = "Eustracjusz Baranowski",
                            LengthInMinutes = 62,
                            ReleaseDate = new DateTime(2007, 7, 23, 2, 59, 7, 571, DateTimeKind.Local).AddTicks(7006),
                            Title = "Rustic Wooden Shirt"
                        },
                        new
                        {
                            Id = 18,
                            CountryOfOrigin = "Armenia",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Director = "Nazariusz Szczepaniak",
                            LengthInMinutes = 239,
                            ReleaseDate = new DateTime(1999, 7, 5, 8, 48, 8, 963, DateTimeKind.Local).AddTicks(2004),
                            Title = "Fantastic Frozen Computer"
                        },
                        new
                        {
                            Id = 19,
                            CountryOfOrigin = "Burkina Faso",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Director = "Hipolit Gadomski",
                            LengthInMinutes = 204,
                            ReleaseDate = new DateTime(2012, 7, 9, 21, 23, 41, 447, DateTimeKind.Local).AddTicks(5622),
                            Title = "Practical Concrete Shoes"
                        },
                        new
                        {
                            Id = 20,
                            CountryOfOrigin = "Wyspy Marshalla",
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Director = "Filemon Falkowski",
                            LengthInMinutes = 159,
                            ReleaseDate = new DateTime(2006, 1, 22, 11, 18, 22, 804, DateTimeKind.Local).AddTicks(4545),
                            Title = "Fantastic Plastic Table"
                        },
                        new
                        {
                            Id = 21,
                            CountryOfOrigin = "Francja",
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Director = "Pankracy Ossowski",
                            LengthInMinutes = 189,
                            ReleaseDate = new DateTime(2016, 11, 29, 19, 57, 50, 752, DateTimeKind.Local).AddTicks(8954),
                            Title = "Generic Metal Towels"
                        },
                        new
                        {
                            Id = 22,
                            CountryOfOrigin = "Kongo",
                            Description = "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive",
                            Director = "Jerzy Marchewka",
                            LengthInMinutes = 109,
                            ReleaseDate = new DateTime(2012, 2, 16, 12, 34, 20, 135, DateTimeKind.Local).AddTicks(8309),
                            Title = "Gorgeous Plastic Computer"
                        },
                        new
                        {
                            Id = 23,
                            CountryOfOrigin = "Togo",
                            Description = "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients",
                            Director = "Malwina Wilczyński",
                            LengthInMinutes = 95,
                            ReleaseDate = new DateTime(2018, 10, 3, 3, 31, 25, 998, DateTimeKind.Local).AddTicks(1482),
                            Title = "Intelligent Cotton Bike"
                        },
                        new
                        {
                            Id = 24,
                            CountryOfOrigin = "Boliwia",
                            Description = "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J",
                            Director = "Cyra Kotowski",
                            LengthInMinutes = 194,
                            ReleaseDate = new DateTime(2017, 8, 31, 15, 0, 22, 905, DateTimeKind.Local).AddTicks(7486),
                            Title = "Handcrafted Concrete Bacon"
                        },
                        new
                        {
                            Id = 25,
                            CountryOfOrigin = "Mołdawia",
                            Description = "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality",
                            Director = "Patrycja Kruk",
                            LengthInMinutes = 200,
                            ReleaseDate = new DateTime(1999, 11, 18, 14, 27, 52, 995, DateTimeKind.Local).AddTicks(5643),
                            Title = "Rustic Frozen Bike"
                        },
                        new
                        {
                            Id = 26,
                            CountryOfOrigin = "Austria",
                            Description = "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles",
                            Director = "Franciszka Bukowski",
                            LengthInMinutes = 187,
                            ReleaseDate = new DateTime(2005, 12, 23, 14, 7, 0, 437, DateTimeKind.Local).AddTicks(661),
                            Title = "Awesome Wooden Towels"
                        },
                        new
                        {
                            Id = 27,
                            CountryOfOrigin = "Mongolia",
                            Description = "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals",
                            Director = "Melania Surma",
                            LengthInMinutes = 132,
                            ReleaseDate = new DateTime(1997, 6, 18, 14, 4, 15, 638, DateTimeKind.Local).AddTicks(1157),
                            Title = "Ergonomic Rubber Mouse"
                        },
                        new
                        {
                            Id = 28,
                            CountryOfOrigin = "Zjednoczone Emiraty Arabskie",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Director = "Gerald Tomaszewski",
                            LengthInMinutes = 48,
                            ReleaseDate = new DateTime(2010, 10, 3, 21, 30, 56, 979, DateTimeKind.Local).AddTicks(4871),
                            Title = "Incredible Rubber Salad"
                        },
                        new
                        {
                            Id = 29,
                            CountryOfOrigin = "Samoa",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Elżbieta Sołtysiak",
                            LengthInMinutes = 118,
                            ReleaseDate = new DateTime(1997, 7, 20, 18, 2, 12, 959, DateTimeKind.Local).AddTicks(6916),
                            Title = "Generic Frozen Chicken"
                        },
                        new
                        {
                            Id = 30,
                            CountryOfOrigin = "Brunei",
                            Description = "The Football Is Good For Training And Recreational Purposes",
                            Director = "Beatrycze Kaczmarek",
                            LengthInMinutes = 194,
                            ReleaseDate = new DateTime(2005, 8, 22, 0, 44, 38, 305, DateTimeKind.Local).AddTicks(6115),
                            Title = "Awesome Concrete Shoes"
                        },
                        new
                        {
                            Id = 31,
                            CountryOfOrigin = "Gwinea Równikowa",
                            Description = "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016",
                            Director = "Ludwik Drozdowski",
                            LengthInMinutes = 29,
                            ReleaseDate = new DateTime(2020, 11, 21, 19, 46, 58, 66, DateTimeKind.Local).AddTicks(7606),
                            Title = "Awesome Wooden Shirt"
                        },
                        new
                        {
                            Id = 32,
                            CountryOfOrigin = "Wenezuela",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Prokop Góral",
                            LengthInMinutes = 208,
                            ReleaseDate = new DateTime(2005, 3, 30, 16, 36, 15, 968, DateTimeKind.Local).AddTicks(3892),
                            Title = "Handcrafted Concrete Chair"
                        },
                        new
                        {
                            Id = 33,
                            CountryOfOrigin = "Nigeria",
                            Description = "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart",
                            Director = "Stella Dudzik",
                            LengthInMinutes = 227,
                            ReleaseDate = new DateTime(2016, 5, 22, 20, 19, 52, 750, DateTimeKind.Local).AddTicks(2053),
                            Title = "Rustic Wooden Chips"
                        },
                        new
                        {
                            Id = 34,
                            CountryOfOrigin = "Argentyna",
                            Description = "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support",
                            Director = "Onufry Dobrowolski",
                            LengthInMinutes = 102,
                            ReleaseDate = new DateTime(2000, 2, 1, 14, 45, 24, 726, DateTimeKind.Local).AddTicks(2211),
                            Title = "Small Wooden Pizza"
                        },
                        new
                        {
                            Id = 35,
                            CountryOfOrigin = "Nikaragua",
                            Description = "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit",
                            Director = "Pankracy Balcerzak",
                            LengthInMinutes = 128,
                            ReleaseDate = new DateTime(2006, 7, 31, 13, 0, 6, 196, DateTimeKind.Local).AddTicks(7391),
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
