using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class anamnezForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BasenÖlcüsü",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BelÖlcüsü",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Boy",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GögüsÖlcüsü",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Kilo",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasenÖlcüsü",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "BelÖlcüsü",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "Boy",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "GögüsÖlcüsü",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "Kilo",
                table: "AnamnezForms");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 570, DateTimeKind.Local).AddTicks(4424), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4019), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4027), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4030), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4032), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4102), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4104), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4326));
        }
    }
}
