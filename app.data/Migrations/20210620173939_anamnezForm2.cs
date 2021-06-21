using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class anamnezForm2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Yas",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 39, 38, 312, DateTimeKind.Local).AddTicks(2302), new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1502), new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1510), new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1512), new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1515), new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1517), new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1519), new DateTime(2021, 6, 20, 20, 39, 38, 313, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 39, 38, 316, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 39, 38, 316, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 39, 38, 316, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 39, 38, 316, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 39, 38, 316, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 39, 38, 316, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 39, 38, 316, DateTimeKind.Local).AddTicks(3872));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Yas",
                table: "AnamnezForms");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 27, 53, 136, DateTimeKind.Local).AddTicks(5482), new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6603), new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6612), new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6613) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6614), new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6617), new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6619), new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6622), new DateTime(2021, 6, 20, 20, 27, 53, 137, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 27, 53, 141, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 27, 53, 141, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 27, 53, 141, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 27, 53, 141, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 27, 53, 141, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 27, 53, 141, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 20, 27, 53, 141, DateTimeKind.Local).AddTicks(1816));
        }
    }
}
