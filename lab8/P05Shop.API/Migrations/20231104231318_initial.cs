using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LengthInMinutes = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Director = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CountryOfOrigin", "Director", "Genre", "LengthInMinutes", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Togo", "Theresa Bergnaum", "Electronics", 196, new DateTime(2011, 9, 10, 0, 58, 37, 191, DateTimeKind.Local).AddTicks(6788), "Practical Metal Computer" },
                    { 2, "Uzbekistan", "Doug Conroy", "Electronics", 33, new DateTime(2018, 7, 7, 21, 30, 48, 860, DateTimeKind.Local).AddTicks(4685), "Small Cotton Chair" },
                    { 3, "Samoa", "Frank Tillman", "Outdoors", 177, new DateTime(1994, 10, 16, 13, 8, 37, 161, DateTimeKind.Local).AddTicks(6045), "Incredible Metal Sausages" },
                    { 4, "Palau", "Alison Strosin", "Outdoors", 137, new DateTime(2017, 10, 15, 17, 17, 31, 407, DateTimeKind.Local).AddTicks(3181), "Intelligent Granite Salad" },
                    { 5, "Heard Island and McDonald Islands", "Annette Kerluke", "Outdoors", 211, new DateTime(2000, 10, 26, 6, 18, 33, 475, DateTimeKind.Local).AddTicks(4026), "Sleek Steel Bacon" },
                    { 6, "Uruguay", "Russell Nienow", "Shoes", 60, new DateTime(1996, 8, 16, 8, 44, 19, 413, DateTimeKind.Local).AddTicks(1442), "Rustic Rubber Mouse" },
                    { 7, "Nicaragua", "Marsha O'Kon", "Computers", 58, new DateTime(2012, 4, 30, 13, 0, 27, 123, DateTimeKind.Local).AddTicks(5360), "Gorgeous Metal Hat" },
                    { 8, "Guadeloupe", "Desiree Von", "Clothing", 57, new DateTime(2013, 2, 28, 4, 55, 34, 451, DateTimeKind.Local).AddTicks(3370), "Fantastic Concrete Keyboard" },
                    { 9, "Kuwait", "Renee Kuhn", "Books", 198, new DateTime(2007, 12, 22, 11, 28, 15, 687, DateTimeKind.Local).AddTicks(1814), "Generic Concrete Chicken" },
                    { 10, "Sao Tome and Principe", "Harriet Kuhn", "Kids", 227, new DateTime(2011, 3, 4, 3, 40, 1, 94, DateTimeKind.Local).AddTicks(5910), "Awesome Plastic Bacon" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
