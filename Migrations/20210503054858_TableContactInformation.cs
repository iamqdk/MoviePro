using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.Migrations
{
    public partial class TableContactInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactInformation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInformation", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 12, 48, 57, 838, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 12, 48, 57, 839, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 12, 48, 57, 839, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 12, 48, 57, 839, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 12, 48, 57, 839, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 12, 48, 57, 839, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 12, 48, 57, 839, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 12, 48, 57, 839, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 12, 48, 57, 839, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 12, 48, 57, 839, DateTimeKind.Local).AddTicks(4708));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactInformation");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 10, 35, 52, 579, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 10, 35, 52, 580, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 10, 35, 52, 580, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 10, 35, 52, 580, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 10, 35, 52, 580, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 10, 35, 52, 580, DateTimeKind.Local).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 10, 35, 52, 580, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 10, 35, 52, 580, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 10, 35, 52, 580, DateTimeKind.Local).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateReleased",
                value: new DateTime(2021, 5, 3, 10, 35, 52, 580, DateTimeKind.Local).AddTicks(9200));
        }
    }
}
