using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class otheriki : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Content",
                table: "DietMenüs",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "DietMenüs");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 30, 30, 699, DateTimeKind.Local).AddTicks(1757), new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2334), new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2341), new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2344), new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2347), new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2349), new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2352), new DateTime(2021, 6, 13, 21, 30, 30, 700, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 30, 30, 705, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 30, 30, 705, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 30, 30, 705, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 30, 30, 705, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 30, 30, 705, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 30, 30, 705, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 30, 30, 705, DateTimeKind.Local).AddTicks(7759));
        }
    }
}
