using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class addedCalendarma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MakingDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentYear = table.Column<int>(type: "int", nullable: false),
                    CurrentMounth = table.Column<int>(type: "int", nullable: false),
                    CurrentDay = table.Column<int>(type: "int", nullable: false),
                    CurrentHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingHour = table.Column<int>(type: "int", nullable: false),
                    FinishedHour = table.Column<int>(type: "int", nullable: false),
                    Traning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DietWekklyId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MakingDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MakingDates_DietWekklies_DietWekklyId",
                        column: x => x.DietWekklyId,
                        principalTable: "DietWekklies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 21, 12, 16, 278, DateTimeKind.Local).AddTicks(2672), new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9041), new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9098), new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9103), new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9107), new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9108) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9112), new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9263), new DateTime(2021, 6, 14, 21, 12, 16, 279, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 21, 12, 16, 290, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 21, 12, 16, 290, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 21, 12, 16, 290, DateTimeKind.Local).AddTicks(2809));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 21, 12, 16, 290, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 21, 12, 16, 290, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 21, 12, 16, 290, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 21, 12, 16, 290, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.CreateIndex(
                name: "IX_MakingDates_DietWekklyId",
                table: "MakingDates",
                column: "DietWekklyId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MakingDates");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 20, 24, 18, 46, DateTimeKind.Local).AddTicks(3498), new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4368), new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4376), new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4379), new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4382), new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4384), new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4387), new DateTime(2021, 6, 14, 20, 24, 18, 47, DateTimeKind.Local).AddTicks(4388) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 20, 24, 18, 50, DateTimeKind.Local).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 20, 24, 18, 50, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 20, 24, 18, 50, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 20, 24, 18, 50, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 20, 24, 18, 50, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 20, 24, 18, 50, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 20, 24, 18, 50, DateTimeKind.Local).AddTicks(8377));
        }
    }
}
