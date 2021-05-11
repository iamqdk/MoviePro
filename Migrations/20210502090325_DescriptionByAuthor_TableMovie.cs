using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.Migrations
{
    public partial class DescriptionByAuthor_TableMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescriptionByAuthor",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 16, 3, 24, 902, DateTimeKind.Local).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 16, 3, 24, 904, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 16, 3, 24, 904, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 16, 3, 24, 904, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 16, 3, 24, 904, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 16, 3, 24, 904, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 16, 3, 24, 904, DateTimeKind.Local).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 16, 3, 24, 904, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 16, 3, 24, 904, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 16, 3, 24, 904, DateTimeKind.Local).AddTicks(1095));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionByAuthor",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 15, 55, 56, 565, DateTimeKind.Local).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateReleased",
                value: new DateTime(2021, 5, 2, 15, 55, 56, 566, DateTimeKind.Local).AddTicks(9179));
        }
    }
}
