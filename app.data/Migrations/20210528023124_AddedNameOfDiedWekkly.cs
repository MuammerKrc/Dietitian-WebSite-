using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class AddedNameOfDiedWekkly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Name",
                table: "DietWekklies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 31, 23, 507, DateTimeKind.Local).AddTicks(6000), new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6519), new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6526), new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6529), new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6532), new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6534), new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6536), new DateTime(2021, 5, 28, 5, 31, 23, 508, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 31, 23, 509, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 31, 23, 509, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 31, 23, 509, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 31, 23, 509, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 31, 23, 509, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 31, 23, 509, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 31, 23, 509, DateTimeKind.Local).AddTicks(1547));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "DietWekklies");

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
    }
}
