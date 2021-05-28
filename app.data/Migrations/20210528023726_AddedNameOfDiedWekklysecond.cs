using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class AddedNameOfDiedWekklysecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DietWekklies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: null);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "DietWekklies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DietWekklies",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: 0);

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
    }
}
