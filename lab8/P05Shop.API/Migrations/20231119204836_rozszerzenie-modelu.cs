using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class rozszerzeniemodelu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReviewId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryOfOrigin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    ReviewerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewerSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Reviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieActors",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActors", x => new { x.MovieId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_MovieActors_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActors_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "GenreId", "ReleaseDate", "ReviewId", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, new DateTime(2009, 4, 16, 6, 8, 34, 680, DateTimeKind.Local).AddTicks(9747), null, "Ergonomic Steel Pants" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "GenreId", "ReleaseDate", "ReviewId", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, new DateTime(2009, 3, 8, 22, 0, 40, 3, DateTimeKind.Local).AddTicks(1249), null, "Intelligent Metal Chips" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "GenreId", "ReleaseDate", "ReviewId", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, new DateTime(1994, 3, 21, 17, 36, 33, 16, DateTimeKind.Local).AddTicks(703), null, "Rustic Rubber Sausages" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "GenreId", "ReleaseDate", "ReviewId", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, new DateTime(2000, 9, 5, 5, 39, 30, 272, DateTimeKind.Local).AddTicks(7053), null, "Fantastic Wooden Chips" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "GenreId", "ReleaseDate", "ReviewId", "Title" },
                values: new object[] { "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", null, new DateTime(2002, 12, 31, 23, 25, 34, 859, DateTimeKind.Local).AddTicks(4326), null, "Tasty Fresh Chips" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "GenreId", "ReleaseDate", "ReviewId", "Title" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", null, new DateTime(2015, 10, 17, 10, 28, 37, 170, DateTimeKind.Local).AddTicks(6541), null, "Incredible Cotton Keyboard" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "GenreId", "ReleaseDate", "ReviewId", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, new DateTime(2004, 1, 18, 14, 44, 19, 137, DateTimeKind.Local).AddTicks(2069), null, "Small Wooden Shirt" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "GenreId", "ReleaseDate", "ReviewId", "Title" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", null, new DateTime(2021, 9, 9, 16, 21, 59, 995, DateTimeKind.Local).AddTicks(1687), null, "Handmade Metal Towels" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "GenreId", "ReleaseDate", "ReviewId", "Title" },
                values: new object[] { "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", null, new DateTime(2000, 9, 18, 17, 18, 57, 196, DateTimeKind.Local).AddTicks(8242), null, "Refined Soft Tuna" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "GenreId", "ReleaseDate", "ReviewId", "Title" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", null, new DateTime(1998, 3, 5, 7, 23, 50, 472, DateTimeKind.Local).AddTicks(8645), null, "Refined Cotton Bacon" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreId",
                table: "Movies",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_ActorId",
                table: "MovieActors",
                column: "ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Genres_GenreId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "MovieActors");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropIndex(
                name: "IX_Movies_GenreId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Tools", new DateTime(2009, 4, 2, 22, 10, 8, 178, DateTimeKind.Local).AddTicks(2334), "Gorgeous Wooden Chair" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Industrial", new DateTime(2009, 2, 23, 14, 2, 13, 500, DateTimeKind.Local).AddTicks(3852), "Fantastic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Automotive", new DateTime(1994, 3, 8, 9, 38, 6, 513, DateTimeKind.Local).AddTicks(3131), "Incredible Wooden Towels" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Industrial", new DateTime(2000, 8, 22, 21, 41, 3, 769, DateTimeKind.Local).AddTicks(9397), "Gorgeous Cotton Computer" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Industrial", new DateTime(2002, 12, 18, 15, 27, 8, 356, DateTimeKind.Local).AddTicks(6656), "Rustic Frozen Bacon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Music", new DateTime(2015, 10, 4, 2, 30, 10, 667, DateTimeKind.Local).AddTicks(8815), "Fantastic Plastic Table" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Grocery", new DateTime(2004, 1, 5, 6, 45, 52, 634, DateTimeKind.Local).AddTicks(4285), "Unbranded Steel Computer" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Toys", new DateTime(2021, 8, 27, 8, 23, 33, 492, DateTimeKind.Local).AddTicks(3914), "Handmade Metal Chicken" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Baby", new DateTime(2000, 9, 5, 9, 20, 30, 694, DateTimeKind.Local).AddTicks(392), "Incredible Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Genre", "ReleaseDate", "Title" },
                values: new object[] { "Sports", new DateTime(1998, 2, 19, 23, 25, 23, 970, DateTimeKind.Local).AddTicks(849), "Unbranded Fresh Table" });
        }
    }
}
