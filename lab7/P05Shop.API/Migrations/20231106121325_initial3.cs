using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P05Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "ReleaseDate",
                value: new DateTime(2009, 4, 2, 21, 33, 23, 379, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "ReleaseDate",
                value: new DateTime(2009, 2, 23, 13, 25, 28, 701, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "ReleaseDate",
                value: new DateTime(1994, 3, 8, 9, 1, 21, 714, DateTimeKind.Local).AddTicks(1636));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "ReleaseDate",
                value: new DateTime(2000, 8, 22, 21, 4, 18, 970, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "ReleaseDate",
                value: new DateTime(2002, 12, 18, 14, 50, 23, 557, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "ReleaseDate",
                value: new DateTime(2015, 10, 4, 1, 53, 25, 868, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "ReleaseDate",
                value: new DateTime(2004, 1, 5, 6, 9, 7, 835, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "ReleaseDate",
                value: new DateTime(2021, 8, 27, 7, 46, 48, 693, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "ReleaseDate",
                value: new DateTime(2000, 9, 5, 8, 43, 45, 894, DateTimeKind.Local).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "ReleaseDate",
                value: new DateTime(1998, 2, 19, 22, 48, 39, 170, DateTimeKind.Local).AddTicks(9376));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
