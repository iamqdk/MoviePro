using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviePro.Migrations
{
    public partial class TableFavoriteMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteMovie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameFavoriteMovie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TmpId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteMovie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FavoriteMovie_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteMovie_UserId",
                table: "FavoriteMovie",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteMovie");

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
    }
}
