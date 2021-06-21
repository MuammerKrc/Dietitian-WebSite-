using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class anamnezForm4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Yas",
                table: "AnamnezForms",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Soru24",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Soru23",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Soru22",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Soru21",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Soru20",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Soru19",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Soru18",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Soru17",
                table: "AnamnezForms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Kilo",
                table: "AnamnezForms",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "GögüsÖlcüsü",
                table: "AnamnezForms",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "Boy",
                table: "AnamnezForms",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "BelÖlcüsü",
                table: "AnamnezForms",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "BasenÖlcüsü",
                table: "AnamnezForms",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 21, 0, 45, 26, 828, DateTimeKind.Local).AddTicks(1204), new DateTime(2021, 6, 21, 0, 45, 26, 828, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1859), new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1869), new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1872), new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1876), new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1878), new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1881), new DateTime(2021, 6, 21, 0, 45, 26, 829, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 21, 0, 45, 26, 832, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 21, 0, 45, 26, 833, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 21, 0, 45, 26, 833, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 21, 0, 45, 26, 833, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 21, 0, 45, 26, 833, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 21, 0, 45, 26, 833, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 21, 0, 45, 26, 833, DateTimeKind.Local).AddTicks(128));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Yas",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru24",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru23",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru22",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru21",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru20",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru19",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru18",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru17",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Kilo",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "GögüsÖlcüsü",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Boy",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BelÖlcüsü",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "BasenÖlcüsü",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 23, 27, 37, 753, DateTimeKind.Local).AddTicks(9950), new DateTime(2021, 6, 20, 23, 27, 37, 754, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1914), new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1934), new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1941), new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1948), new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1954), new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1963), new DateTime(2021, 6, 20, 23, 27, 37, 755, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 23, 27, 37, 759, DateTimeKind.Local).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 23, 27, 37, 759, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 23, 27, 37, 759, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 23, 27, 37, 759, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 23, 27, 37, 759, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 23, 27, 37, 759, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 23, 27, 37, 759, DateTimeKind.Local).AddTicks(2858));
        }
    }
}
