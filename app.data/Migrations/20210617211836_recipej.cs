using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class recipej : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "GeneralMesajs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 0, 18, 35, 667, DateTimeKind.Local).AddTicks(1015), new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6710), new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6715) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6718), new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6721), new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6724), new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6727), new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6729), new DateTime(2021, 6, 18, 0, 18, 35, 668, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 0, 18, 35, 673, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 0, 18, 35, 673, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 0, 18, 35, 673, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 0, 18, 35, 673, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 0, 18, 35, 673, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 0, 18, 35, 673, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 0, 18, 35, 673, DateTimeKind.Local).AddTicks(627));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "GeneralMesajs");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 3, 55, 104, DateTimeKind.Local).AddTicks(8397), new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(7535) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9271), new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9279), new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9282), new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9285), new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9288), new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9290), new DateTime(2021, 6, 17, 22, 3, 55, 105, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 17, 22, 3, 55, 109, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 17, 22, 3, 55, 109, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 17, 22, 3, 55, 109, DateTimeKind.Local).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 17, 22, 3, 55, 109, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 17, 22, 3, 55, 109, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 17, 22, 3, 55, 109, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 17, 22, 3, 55, 109, DateTimeKind.Local).AddTicks(6773));
        }
    }
}
