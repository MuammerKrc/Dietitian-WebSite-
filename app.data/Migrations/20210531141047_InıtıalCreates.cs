using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class InıtıalCreates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "water",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Tea",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Soda",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Juice",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HerbalTea",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Cola",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Coffea",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Alkol",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 17, 10, 47, 112, DateTimeKind.Local).AddTicks(2916), new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5364), new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5373), new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5376), new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5379), new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5381), new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5382) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5383), new DateTime(2021, 5, 31, 17, 10, 47, 113, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 17, 10, 47, 115, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 17, 10, 47, 116, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 17, 10, 47, 116, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 17, 10, 47, 116, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 17, 10, 47, 116, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 17, 10, 47, 116, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 17, 10, 47, 116, DateTimeKind.Local).AddTicks(168));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "water",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Tea",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soda",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Juice",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HerbalTea",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cola",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Coffea",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Alkol",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 15, 38, 59, 823, DateTimeKind.Local).AddTicks(1375), new DateTime(2021, 5, 31, 15, 38, 59, 823, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(585), new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(591) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(593), new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(596), new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(597) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(598), new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(600), new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(603), new DateTime(2021, 5, 31, 15, 38, 59, 824, DateTimeKind.Local).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 15, 38, 59, 826, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 15, 38, 59, 826, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 15, 38, 59, 826, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 15, 38, 59, 826, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 15, 38, 59, 826, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 15, 38, 59, 826, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 5, 31, 15, 38, 59, 826, DateTimeKind.Local).AddTicks(4561));
        }
    }
}
