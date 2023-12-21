using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class addUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2009, 4, 29, 5, 42, 44, 143, DateTimeKind.Local).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2009, 3, 21, 21, 34, 49, 465, DateTimeKind.Local).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(1994, 4, 3, 17, 10, 42, 478, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2000, 9, 18, 5, 13, 39, 735, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2003, 1, 13, 22, 59, 44, 322, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2015, 10, 30, 10, 2, 46, 633, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2004, 1, 31, 14, 18, 28, 599, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2021, 9, 22, 15, 56, 9, 457, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2000, 10, 1, 16, 53, 6, 659, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(1998, 3, 18, 6, 57, 59, 935, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(1997, 11, 30, 16, 53, 38, 442, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2014, 3, 16, 13, 28, 11, 606, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2004, 12, 31, 14, 32, 14, 419, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2003, 4, 3, 13, 52, 16, 904, DateTimeKind.Local).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2014, 5, 19, 6, 20, 33, 749, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2017, 3, 1, 14, 46, 16, 250, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2007, 8, 5, 0, 42, 28, 886, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(1999, 7, 18, 6, 31, 30, 277, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2012, 7, 22, 19, 7, 2, 762, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2006, 2, 4, 9, 1, 44, 119, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2016, 12, 12, 17, 41, 12, 67, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2012, 2, 29, 10, 17, 41, 450, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2018, 10, 16, 1, 14, 47, 312, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2017, 9, 13, 12, 43, 44, 220, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(1999, 12, 1, 12, 11, 14, 310, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2006, 1, 5, 11, 50, 21, 751, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(1997, 7, 1, 11, 47, 36, 952, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2010, 10, 16, 19, 14, 18, 294, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(1997, 8, 2, 15, 45, 34, 274, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2005, 9, 3, 22, 27, 59, 620, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2020, 12, 4, 17, 30, 19, 381, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2005, 4, 12, 14, 19, 37, 282, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2016, 6, 4, 18, 3, 14, 64, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2000, 2, 14, 12, 28, 46, 40, DateTimeKind.Local).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2006, 8, 13, 10, 43, 27, 511, DateTimeKind.Local).AddTicks(2372));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 11,
                column: "ReleaseDate",
                value: new DateTime(1997, 11, 17, 19, 10, 17, 128, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 12,
                column: "ReleaseDate",
                value: new DateTime(2014, 3, 3, 15, 44, 50, 291, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 13,
                column: "ReleaseDate",
                value: new DateTime(2004, 12, 18, 16, 48, 53, 105, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 14,
                column: "ReleaseDate",
                value: new DateTime(2003, 3, 21, 16, 8, 55, 589, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 15,
                column: "ReleaseDate",
                value: new DateTime(2014, 5, 6, 8, 37, 12, 434, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 16,
                column: "ReleaseDate",
                value: new DateTime(2017, 2, 16, 17, 2, 54, 935, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 17,
                column: "ReleaseDate",
                value: new DateTime(2007, 7, 23, 2, 59, 7, 571, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 18,
                column: "ReleaseDate",
                value: new DateTime(1999, 7, 5, 8, 48, 8, 963, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 19,
                column: "ReleaseDate",
                value: new DateTime(2012, 7, 9, 21, 23, 41, 447, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 20,
                column: "ReleaseDate",
                value: new DateTime(2006, 1, 22, 11, 18, 22, 804, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 21,
                column: "ReleaseDate",
                value: new DateTime(2016, 11, 29, 19, 57, 50, 752, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 22,
                column: "ReleaseDate",
                value: new DateTime(2012, 2, 16, 12, 34, 20, 135, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 23,
                column: "ReleaseDate",
                value: new DateTime(2018, 10, 3, 3, 31, 25, 998, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 24,
                column: "ReleaseDate",
                value: new DateTime(2017, 8, 31, 15, 0, 22, 905, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 25,
                column: "ReleaseDate",
                value: new DateTime(1999, 11, 18, 14, 27, 52, 995, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 26,
                column: "ReleaseDate",
                value: new DateTime(2005, 12, 23, 14, 7, 0, 437, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 27,
                column: "ReleaseDate",
                value: new DateTime(1997, 6, 18, 14, 4, 15, 638, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 28,
                column: "ReleaseDate",
                value: new DateTime(2010, 10, 3, 21, 30, 56, 979, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 29,
                column: "ReleaseDate",
                value: new DateTime(1997, 7, 20, 18, 2, 12, 959, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 30,
                column: "ReleaseDate",
                value: new DateTime(2005, 8, 22, 0, 44, 38, 305, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 31,
                column: "ReleaseDate",
                value: new DateTime(2020, 11, 21, 19, 46, 58, 66, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 32,
                column: "ReleaseDate",
                value: new DateTime(2005, 3, 30, 16, 36, 15, 968, DateTimeKind.Local).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 33,
                column: "ReleaseDate",
                value: new DateTime(2016, 5, 22, 20, 19, 52, 750, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 34,
                column: "ReleaseDate",
                value: new DateTime(2000, 2, 1, 14, 45, 24, 726, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 35,
                column: "ReleaseDate",
                value: new DateTime(2006, 7, 31, 13, 0, 6, 196, DateTimeKind.Local).AddTicks(7391));
        }
    }
}
