using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class rozszerzeniemodelu2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2009, 4, 16, 7, 59, 22, 829, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2009, 3, 8, 23, 51, 28, 151, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(1994, 3, 21, 19, 27, 21, 164, DateTimeKind.Local).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2000, 9, 5, 7, 30, 18, 420, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2003, 1, 1, 1, 16, 23, 7, DateTimeKind.Local).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2015, 10, 17, 12, 19, 25, 318, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2004, 1, 18, 16, 35, 7, 285, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2021, 9, 9, 18, 12, 48, 143, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2000, 9, 18, 19, 9, 45, 344, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(1998, 3, 5, 9, 14, 38, 620, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CountryOfOrigin", "Description", "Director", "GenreId", "LengthInMinutes", "ReleaseDate", "ReviewId", "Title" },
                values: new object[,]
                {
                    { 11, "Nauru", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Erwin Mroczek", null, 46, new DateTime(1997, 11, 17, 19, 10, 17, 128, DateTimeKind.Local).AddTicks(1315), null, "Rustic Frozen Sausages" },
                    { 12, "Malawi", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Noemi Szczerba", null, 168, new DateTime(2014, 3, 3, 15, 44, 50, 291, DateTimeKind.Local).AddTicks(5360), null, "Unbranded Soft Cheese" },
                    { 13, "Bułgaria", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Lilia Zdunek", null, 104, new DateTime(2004, 12, 18, 16, 48, 53, 105, DateTimeKind.Local).AddTicks(3193), null, "Awesome Concrete Bike" },
                    { 14, "Kirgistan", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fabian Jóźwiak", null, 99, new DateTime(2003, 3, 21, 16, 8, 55, 589, DateTimeKind.Local).AddTicks(8418), null, "Gorgeous Frozen Salad" },
                    { 15, "Portugalia", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Agata Wesołowski", null, 134, new DateTime(2014, 5, 6, 8, 37, 12, 434, DateTimeKind.Local).AddTicks(8730), null, "Incredible Concrete Gloves" },
                    { 16, "Liban", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Alan Gwóźdź", null, 158, new DateTime(2017, 2, 16, 17, 2, 54, 935, DateTimeKind.Local).AddTicks(9974), null, "Awesome Plastic Salad" },
                    { 17, "Malezja", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Eustracjusz Baranowski", null, 62, new DateTime(2007, 7, 23, 2, 59, 7, 571, DateTimeKind.Local).AddTicks(7006), null, "Rustic Wooden Shirt" },
                    { 18, "Armenia", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Nazariusz Szczepaniak", null, 239, new DateTime(1999, 7, 5, 8, 48, 8, 963, DateTimeKind.Local).AddTicks(2004), null, "Fantastic Frozen Computer" },
                    { 19, "Burkina Faso", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Hipolit Gadomski", null, 204, new DateTime(2012, 7, 9, 21, 23, 41, 447, DateTimeKind.Local).AddTicks(5622), null, "Practical Concrete Shoes" },
                    { 20, "Wyspy Marshalla", "The Football Is Good For Training And Recreational Purposes", "Filemon Falkowski", null, 159, new DateTime(2006, 1, 22, 11, 18, 22, 804, DateTimeKind.Local).AddTicks(4545), null, "Fantastic Plastic Table" },
                    { 21, "Francja", "The Football Is Good For Training And Recreational Purposes", "Pankracy Ossowski", null, 189, new DateTime(2016, 11, 29, 19, 57, 50, 752, DateTimeKind.Local).AddTicks(8954), null, "Generic Metal Towels" },
                    { 22, "Kongo", "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Jerzy Marchewka", null, 109, new DateTime(2012, 2, 16, 12, 34, 20, 135, DateTimeKind.Local).AddTicks(8309), null, "Gorgeous Plastic Computer" },
                    { 23, "Togo", "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Malwina Wilczyński", null, 95, new DateTime(2018, 10, 3, 3, 31, 25, 998, DateTimeKind.Local).AddTicks(1482), null, "Intelligent Cotton Bike" },
                    { 24, "Boliwia", "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Cyra Kotowski", null, 194, new DateTime(2017, 8, 31, 15, 0, 22, 905, DateTimeKind.Local).AddTicks(7486), null, "Handcrafted Concrete Bacon" },
                    { 25, "Mołdawia", "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Patrycja Kruk", null, 200, new DateTime(1999, 11, 18, 14, 27, 52, 995, DateTimeKind.Local).AddTicks(5643), null, "Rustic Frozen Bike" },
                    { 26, "Austria", "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Franciszka Bukowski", null, 187, new DateTime(2005, 12, 23, 14, 7, 0, 437, DateTimeKind.Local).AddTicks(661), null, "Awesome Wooden Towels" },
                    { 27, "Mongolia", "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Melania Surma", null, 132, new DateTime(1997, 6, 18, 14, 4, 15, 638, DateTimeKind.Local).AddTicks(1157), null, "Ergonomic Rubber Mouse" },
                    { 28, "Zjednoczone Emiraty Arabskie", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gerald Tomaszewski", null, 48, new DateTime(2010, 10, 3, 21, 30, 56, 979, DateTimeKind.Local).AddTicks(4871), null, "Incredible Rubber Salad" },
                    { 29, "Samoa", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Elżbieta Sołtysiak", null, 118, new DateTime(1997, 7, 20, 18, 2, 12, 959, DateTimeKind.Local).AddTicks(6916), null, "Generic Frozen Chicken" },
                    { 30, "Brunei", "The Football Is Good For Training And Recreational Purposes", "Beatrycze Kaczmarek", null, 194, new DateTime(2005, 8, 22, 0, 44, 38, 305, DateTimeKind.Local).AddTicks(6115), null, "Awesome Concrete Shoes" },
                    { 31, "Gwinea Równikowa", "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ludwik Drozdowski", null, 29, new DateTime(2020, 11, 21, 19, 46, 58, 66, DateTimeKind.Local).AddTicks(7606), null, "Awesome Wooden Shirt" },
                    { 32, "Wenezuela", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Prokop Góral", null, 208, new DateTime(2005, 3, 30, 16, 36, 15, 968, DateTimeKind.Local).AddTicks(3892), null, "Handcrafted Concrete Chair" },
                    { 33, "Nigeria", "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Stella Dudzik", null, 227, new DateTime(2016, 5, 22, 20, 19, 52, 750, DateTimeKind.Local).AddTicks(2053), null, "Rustic Wooden Chips" },
                    { 34, "Argentyna", "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Onufry Dobrowolski", null, 102, new DateTime(2000, 2, 1, 14, 45, 24, 726, DateTimeKind.Local).AddTicks(2211), null, "Small Wooden Pizza" },
                    { 35, "Nikaragua", "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Pankracy Balcerzak", null, 128, new DateTime(2006, 7, 31, 13, 0, 6, 196, DateTimeKind.Local).AddTicks(7391), null, "Incredible Concrete Mouse" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2009, 4, 16, 6, 8, 34, 680, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2009, 3, 8, 22, 0, 40, 3, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(1994, 3, 21, 17, 36, 33, 16, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2000, 9, 5, 5, 39, 30, 272, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2002, 12, 31, 23, 25, 34, 859, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2015, 10, 17, 10, 28, 37, 170, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2004, 1, 18, 14, 44, 19, 137, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2021, 9, 9, 16, 21, 59, 995, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2000, 9, 18, 17, 18, 57, 196, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(1998, 3, 5, 7, 23, 50, 472, DateTimeKind.Local).AddTicks(8645));
        }
    }
}
