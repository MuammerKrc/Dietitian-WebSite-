using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class addedUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsUpdate",
                table: "DietWekklies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 570, DateTimeKind.Local).AddTicks(4424), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4019), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4024) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4027), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4028) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4030), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4031) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4032), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4033) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4102), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4104), new DateTime(2021, 6, 20, 3, 25, 6, 571, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 20, 3, 25, 6, 575, DateTimeKind.Local).AddTicks(4326));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsUpdate",
                table: "DietWekklies");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 900, DateTimeKind.Local).AddTicks(1929), new DateTime(2021, 6, 19, 23, 16, 25, 900, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1051), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1058), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1061), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1063), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1065), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1068), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3366));
        }
    }
}
