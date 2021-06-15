using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class ınitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 25, 17, 21, DateTimeKind.Local).AddTicks(8498), new DateTime(2021, 6, 13, 21, 25, 17, 22, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2306), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2317), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2320), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2323), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2326), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2328), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3162));
        }
    }
}
