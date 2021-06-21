using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class anamnezForm3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alkol",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "Coffea",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "Cola",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "HerbalTea",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "Juice",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "Soda",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "Tea",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "water",
                table: "AnamnezForms");

            migrationBuilder.RenameColumn(
                name: "snack3",
                table: "AnamnezForms",
                newName: "Soru30");

            migrationBuilder.RenameColumn(
                name: "noon",
                table: "AnamnezForms",
                newName: "Soru29");

            migrationBuilder.RenameColumn(
                name: "morning",
                table: "AnamnezForms",
                newName: "Soru28");

            migrationBuilder.RenameColumn(
                name: "Snack2",
                table: "AnamnezForms",
                newName: "Soru27");

            migrationBuilder.RenameColumn(
                name: "Snack1",
                table: "AnamnezForms",
                newName: "Soru26");

            migrationBuilder.RenameColumn(
                name: "Evening",
                table: "AnamnezForms",
                newName: "Soru25");

            migrationBuilder.AlterColumn<float>(
                name: "Yas",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Soru20",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru19",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru18",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Soru17",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Kilo",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "GögüsÖlcüsü",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Boy",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "BelÖlcüsü",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "BasenÖlcüsü",
                table: "AnamnezForms",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Soru21",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Soru22",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Soru23",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Soru24",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Soru21",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "Soru22",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "Soru23",
                table: "AnamnezForms");

            migrationBuilder.DropColumn(
                name: "Soru24",
                table: "AnamnezForms");

            migrationBuilder.RenameColumn(
                name: "Soru30",
                table: "AnamnezForms",
                newName: "snack3");

            migrationBuilder.RenameColumn(
                name: "Soru29",
                table: "AnamnezForms",
                newName: "noon");

            migrationBuilder.RenameColumn(
                name: "Soru28",
                table: "AnamnezForms",
                newName: "morning");

            migrationBuilder.RenameColumn(
                name: "Soru27",
                table: "AnamnezForms",
                newName: "Snack2");

            migrationBuilder.RenameColumn(
                name: "Soru26",
                table: "AnamnezForms",
                newName: "Snack1");

            migrationBuilder.RenameColumn(
                name: "Soru25",
                table: "AnamnezForms",
                newName: "Evening");

            migrationBuilder.AlterColumn<int>(
                name: "Yas",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "Soru20",
                table: "AnamnezForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Soru19",
                table: "AnamnezForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Soru18",
                table: "AnamnezForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Soru17",
                table: "AnamnezForms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Kilo",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "GögüsÖlcüsü",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Boy",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "BelÖlcüsü",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "BasenÖlcüsü",
                table: "AnamnezForms",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "Alkol",
                table: "AnamnezForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Coffea",
                table: "AnamnezForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cola",
                table: "AnamnezForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HerbalTea",
                table: "AnamnezForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Juice",
                table: "AnamnezForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Soda",
                table: "AnamnezForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Tea",
                table: "AnamnezForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "water",
                table: "AnamnezForms",
                type: "int",
                nullable: true);

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
    }
}
