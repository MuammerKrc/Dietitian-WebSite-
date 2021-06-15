using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class aaddedCalendarasd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemainingPackages",
                table: "Pilateis");

            migrationBuilder.DropColumn(
                name: "RemainingPackages",
                table: "Diets");

            migrationBuilder.AddColumn<int>(
                name: "RemaningDietPackages",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RemaningPilatesPackages",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 32, 46, 395, DateTimeKind.Local).AddTicks(5245), new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6186), new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6194), new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6198), new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6201), new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6203), new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6206), new DateTime(2021, 6, 15, 16, 32, 46, 396, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 32, 46, 400, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 32, 46, 400, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 32, 46, 400, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 32, 46, 400, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 32, 46, 400, DateTimeKind.Local).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 32, 46, 400, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 15, 16, 32, 46, 400, DateTimeKind.Local).AddTicks(3042));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemaningDietPackages",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "RemaningPilatesPackages",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "RemainingPackages",
                table: "Pilateis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RemainingPackages",
                table: "Diets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 535, DateTimeKind.Local).AddTicks(8294), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8814), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8823), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8826), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8829), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8832), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8834), new DateTime(2021, 6, 15, 16, 6, 33, 536, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateStart", "RemainingPackages" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(5143), 8 });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateStart", "RemainingPackages" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(5992), 8 });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateStart", "RemainingPackages" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(5998), 8 });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateStart", "RemainingPackages" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(6000), 8 });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateStart", "RemainingPackages" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(6001), 8 });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateStart", "RemainingPackages" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(6003), 8 });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateStart", "RemainingPackages" },
                values: new object[] { new DateTime(2021, 6, 15, 16, 6, 33, 540, DateTimeKind.Local).AddTicks(6004), 8 });
        }
    }
}
