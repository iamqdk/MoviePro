using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.Migrations
{
    public partial class NumberChapter_TableMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberChapter",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2021, 5, 4, 17, 55, 32, 438, DateTimeKind.Local).AddTicks(4755));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2021, 5, 4, 17, 55, 32, 439, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateReleased",
                value: new DateTime(2021, 5, 4, 17, 55, 32, 439, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateReleased",
                value: new DateTime(2021, 5, 4, 17, 55, 32, 439, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateReleased",
                value: new DateTime(2021, 5, 4, 17, 55, 32, 439, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateReleased",
                value: new DateTime(2021, 5, 4, 17, 55, 32, 439, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateReleased",
                value: new DateTime(2021, 5, 4, 17, 55, 32, 439, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateReleased",
                value: new DateTime(2021, 5, 4, 17, 55, 32, 439, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateReleased",
                value: new DateTime(2021, 5, 4, 17, 55, 32, 439, DateTimeKind.Local).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateReleased",
                value: new DateTime(2021, 5, 4, 17, 55, 32, 439, DateTimeKind.Local).AddTicks(7736));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberChapter",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 14, 2, 6, 904, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 14, 2, 6, 906, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 14, 2, 6, 906, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 14, 2, 6, 906, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 14, 2, 6, 906, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 14, 2, 6, 906, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 14, 2, 6, 906, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 14, 2, 6, 906, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 14, 2, 6, 906, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 14, 2, 6, 906, DateTimeKind.Local).AddTicks(2445));
        }
    }
}
