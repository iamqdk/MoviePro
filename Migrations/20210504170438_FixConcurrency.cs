using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.Migrations
{
    public partial class FixConcurrency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2021, 5, 5, 0, 4, 37, 696, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateReleased",
                value: new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateReleased",
                value: new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateReleased",
                value: new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateReleased",
                value: new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateReleased",
                value: new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateReleased",
                value: new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateReleased",
                value: new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateReleased",
                value: new DateTime(2021, 5, 5, 0, 4, 37, 697, DateTimeKind.Local).AddTicks(6669));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
