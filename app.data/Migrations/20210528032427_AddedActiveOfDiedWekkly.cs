using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class AddedActiveOfDiedWekkly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "DietWekklies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 6, 24, 26, 584, DateTimeKind.Local).AddTicks(967), new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(647) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2362), new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2371), new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2374), new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2376), new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2379), new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2381), new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 6, 24, 26, 585, DateTimeKind.Local).AddTicks(7276));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "DietWekklies");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 37, 26, 278, DateTimeKind.Local).AddTicks(3715), new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4892), new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4925), new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4931), new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4935), new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4938), new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4941), new DateTime(2021, 5, 28, 5, 37, 26, 279, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 37, 26, 280, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 37, 26, 280, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 37, 26, 280, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 37, 26, 280, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 37, 26, 280, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 37, 26, 280, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 5, 37, 26, 280, DateTimeKind.Local).AddTicks(932));
        }
    }
}
