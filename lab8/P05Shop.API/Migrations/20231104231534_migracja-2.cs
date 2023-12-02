using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class migracja2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Dania", "Władysław Stępień", "Tools", 211, new DateTime(2009, 4, 1, 8, 35, 32, 775, DateTimeKind.Local).AddTicks(1960), "Gorgeous Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Kiribati", "Jakub Nowaczyk", "Industrial", 115, new DateTime(2009, 2, 22, 0, 27, 38, 97, DateTimeKind.Local).AddTicks(3491), "Fantastic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Gujana", "Regina Robak", "Automotive", 156, new DateTime(1994, 3, 6, 20, 3, 31, 110, DateTimeKind.Local).AddTicks(2741), "Incredible Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Trynidad i Tobago", "Łazarz Pawlikowski", "Industrial", 209, new DateTime(2000, 8, 21, 8, 6, 28, 366, DateTimeKind.Local).AddTicks(9019), "Gorgeous Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Republika Środkowoafrykańska", "Wawrzyniec Szczepański", "Industrial", 220, new DateTime(2002, 12, 17, 1, 52, 32, 953, DateTimeKind.Local).AddTicks(6278), "Rustic Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Liberia", "Laura Cygan", "Music", 102, new DateTime(2015, 10, 2, 12, 55, 35, 264, DateTimeKind.Local).AddTicks(8416), "Fantastic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Kenia", "Józef Broda", "Grocery", 171, new DateTime(2004, 1, 3, 17, 11, 17, 231, DateTimeKind.Local).AddTicks(3860), "Unbranded Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Uganda", "Marceli Żurek", "Toys", 88, new DateTime(2021, 8, 25, 18, 48, 58, 89, DateTimeKind.Local).AddTicks(3519), "Handmade Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Mongolia", "Cyrus Nowaczyk", "Baby", 29, new DateTime(2000, 9, 3, 19, 45, 55, 290, DateTimeKind.Local).AddTicks(9982), "Incredible Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Kenia", "Rajnold Stefaniak", "Sports", 180, new DateTime(1998, 2, 18, 9, 50, 48, 567, DateTimeKind.Local).AddTicks(395), "Unbranded Fresh Table" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Togo", "Theresa Bergnaum", "Electronics", 196, new DateTime(2011, 9, 10, 0, 58, 37, 191, DateTimeKind.Local).AddTicks(6788), "Practical Metal Computer" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Uzbekistan", "Doug Conroy", "Electronics", 33, new DateTime(2018, 7, 7, 21, 30, 48, 860, DateTimeKind.Local).AddTicks(4685), "Small Cotton Chair" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Samoa", "Frank Tillman", "Outdoors", 177, new DateTime(1994, 10, 16, 13, 8, 37, 161, DateTimeKind.Local).AddTicks(6045), "Incredible Metal Sausages" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Palau", "Alison Strosin", "Outdoors", 137, new DateTime(2017, 10, 15, 17, 17, 31, 407, DateTimeKind.Local).AddTicks(3181), "Intelligent Granite Salad" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Heard Island and McDonald Islands", "Annette Kerluke", "Outdoors", 211, new DateTime(2000, 10, 26, 6, 18, 33, 475, DateTimeKind.Local).AddTicks(4026), "Sleek Steel Bacon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Uruguay", "Russell Nienow", "Shoes", 60, new DateTime(1996, 8, 16, 8, 44, 19, 413, DateTimeKind.Local).AddTicks(1442), "Rustic Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Nicaragua", "Marsha O'Kon", "Computers", 58, new DateTime(2012, 4, 30, 13, 0, 27, 123, DateTimeKind.Local).AddTicks(5360), "Gorgeous Metal Hat" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Guadeloupe", "Desiree Von", "Clothing", 57, new DateTime(2013, 2, 28, 4, 55, 34, 451, DateTimeKind.Local).AddTicks(3370), "Fantastic Concrete Keyboard" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Kuwait", "Renee Kuhn", "Books", 198, new DateTime(2007, 12, 22, 11, 28, 15, 687, DateTimeKind.Local).AddTicks(1814), "Generic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[] { "Sao Tome and Principe", "Harriet Kuhn", "Kids", 227, new DateTime(2011, 3, 4, 3, 40, 1, 94, DateTimeKind.Local).AddTicks(5910), "Awesome Plastic Bacon" });
        }
    }
}
