using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class addedCalendara : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
