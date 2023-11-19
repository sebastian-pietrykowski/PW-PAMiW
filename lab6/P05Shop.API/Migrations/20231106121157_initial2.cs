using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2009, 4, 2, 21, 31, 55, 530, DateTimeKind.Local).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2009, 2, 23, 13, 24, 0, 852, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(1994, 3, 8, 8, 59, 53, 865, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2000, 8, 22, 21, 2, 51, 122, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2002, 12, 18, 14, 48, 55, 708, DateTimeKind.Local).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2015, 10, 4, 1, 51, 58, 20, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2004, 1, 5, 6, 7, 39, 986, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2021, 8, 27, 7, 45, 20, 844, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2000, 9, 5, 8, 42, 18, 46, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(1998, 2, 19, 22, 47, 11, 322, DateTimeKind.Local).AddTicks(6145));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2009, 4, 1, 8, 35, 32, 775, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2009, 2, 22, 0, 27, 38, 97, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(1994, 3, 6, 20, 3, 31, 110, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2000, 8, 21, 8, 6, 28, 366, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2002, 12, 17, 1, 52, 32, 953, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2015, 10, 2, 12, 55, 35, 264, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2004, 1, 3, 17, 11, 17, 231, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2021, 8, 25, 18, 48, 58, 89, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2000, 9, 3, 19, 45, 55, 290, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(1998, 2, 18, 9, 50, 48, 567, DateTimeKind.Local).AddTicks(395));
        }
    }
}
