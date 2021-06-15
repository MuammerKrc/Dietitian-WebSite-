using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class addedCalendar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hours");

            migrationBuilder.CreateTable(
                name: "Calendars",
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
                    DietWekklyId = table.Column<int>(type: "int", nullable: true),
                    Traning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendars_DietWekklies_DietWekklyId",
                        column: x => x.DietWekklyId,
                        principalTable: "DietWekklies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 19, 8, 58, 476, DateTimeKind.Local).AddTicks(9152), new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9565), new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9573), new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9575) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9577), new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9579), new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9582), new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9584), new DateTime(2021, 6, 14, 19, 8, 58, 477, DateTimeKind.Local).AddTicks(9585) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 19, 8, 58, 483, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 19, 8, 58, 483, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 19, 8, 58, 483, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 19, 8, 58, 483, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 19, 8, 58, 483, DateTimeKind.Local).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 19, 8, 58, 483, DateTimeKind.Local).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 19, 8, 58, 483, DateTimeKind.Local).AddTicks(6147));

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_DietWekklyId",
                table: "Calendars",
                column: "DietWekklyId",
                unique: true,
                filter: "[DietWekklyId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.CreateTable(
                name: "Hours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CurrentDay = table.Column<int>(type: "int", nullable: false),
                    CurrentHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentMounth = table.Column<int>(type: "int", nullable: false),
                    DietWekklyId = table.Column<int>(type: "int", nullable: true),
                    FinishedHour = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingHour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hours_DietWekklies_DietWekklyId",
                        column: x => x.DietWekklyId,
                        principalTable: "DietWekklies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 31, 46, 898, DateTimeKind.Local).AddTicks(292), new DateTime(2021, 6, 14, 1, 31, 46, 898, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(688), new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(696), new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(699), new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(702), new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(704), new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(706), new DateTime(2021, 6, 14, 1, 31, 46, 899, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 31, 46, 904, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 31, 46, 904, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 31, 46, 904, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 31, 46, 904, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 31, 46, 904, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 31, 46, 904, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 31, 46, 904, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.CreateIndex(
                name: "IX_Hours_DietWekklyId",
                table: "Hours",
                column: "DietWekklyId",
                unique: true,
                filter: "[DietWekklyId] IS NOT NULL");
        }
    }
}
