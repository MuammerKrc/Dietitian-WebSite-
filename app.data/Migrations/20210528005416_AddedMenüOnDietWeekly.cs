using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class AddedMenüOnDietWeekly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Menü",
                table: "DietWekklies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 3, 54, 15, 657, DateTimeKind.Local).AddTicks(8240), new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7693), new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7700), new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7702), new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7705), new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7707), new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7709), new DateTime(2021, 5, 28, 3, 54, 15, 658, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 3, 54, 15, 659, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 3, 54, 15, 659, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 3, 54, 15, 659, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 3, 54, 15, 659, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 3, 54, 15, 659, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 3, 54, 15, 659, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 3, 54, 15, 659, DateTimeKind.Local).AddTicks(1723));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Menü",
                table: "DietWekklies");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 0, 8, 11, 592, DateTimeKind.Local).AddTicks(478), new DateTime(2021, 5, 28, 0, 8, 11, 592, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(810), new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(817), new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(819), new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(822), new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(824), new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(826), new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 0, 8, 11, 593, DateTimeKind.Local).AddTicks(4656));
        }
    }
}
