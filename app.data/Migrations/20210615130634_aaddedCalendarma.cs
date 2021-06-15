using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class aaddedCalendarma : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MakingDates");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 535, DateTimeKind.Local).AddTicks(8294), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8814), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8823), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8826), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8829), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8832), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8834), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(6004));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MakingDates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CurrentDay = table.Column<int>(type: "int", nullable: false),
                    CurrentHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentMounth = table.Column<int>(type: "int", nullable: false),
                    CurrentYear = table.Column<int>(type: "int", nullable: false),
                    DietWekklyId = table.Column<int>(type: "int", nullable: false),
                    FinishedHour = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingHour = table.Column<int>(type: "int", nullable: false),
                    Traning = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
    }
}
