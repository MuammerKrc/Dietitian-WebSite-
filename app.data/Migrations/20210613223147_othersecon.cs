using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class othersecon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "DietMenüs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Content",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Content",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Content",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Content",
                value: null);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Content",
                table: "DietMenüs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 4,
                column: "Content",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 5,
                column: "Content",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 6,
                column: "Content",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 7,
                column: "Content",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 8,
                column: "Content",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 9,
                column: "Content",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietMenüs",
                keyColumn: "Id",
                keyValue: 10,
                column: "Content",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 30, 12, 776, DateTimeKind.Local).AddTicks(3834), new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4608), new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4617), new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4620), new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4623), new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4625), new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4628), new DateTime(2021, 6, 14, 1, 30, 12, 777, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 30, 12, 783, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 30, 12, 783, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 30, 12, 783, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 30, 12, 783, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 30, 12, 783, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 30, 12, 783, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 14, 1, 30, 12, 783, DateTimeKind.Local).AddTicks(3917));
        }
    }
}
