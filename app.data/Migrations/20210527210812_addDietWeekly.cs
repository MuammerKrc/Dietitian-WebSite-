using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class addDietWeekly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietWekkly_Diets_DietId",
                table: "DietWekkly");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DietWekkly",
                table: "DietWekkly");

            migrationBuilder.RenameTable(
                name: "DietWekkly",
                newName: "DietWekklies");

            migrationBuilder.RenameIndex(
                name: "IX_DietWekkly_DietId",
                table: "DietWekklies",
                newName: "IX_DietWekklies_DietId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DietWekklies",
                table: "DietWekklies",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_DietWekklies_Diets_DietId",
                table: "DietWekklies",
                column: "DietId",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietWekklies_Diets_DietId",
                table: "DietWekklies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DietWekklies",
                table: "DietWekklies");

            migrationBuilder.RenameTable(
                name: "DietWekklies",
                newName: "DietWekkly");

            migrationBuilder.RenameIndex(
                name: "IX_DietWekklies_DietId",
                table: "DietWekkly",
                newName: "IX_DietWekkly_DietId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DietWekkly",
                table: "DietWekkly",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 27, 2, 34, 37, 795, DateTimeKind.Local).AddTicks(1035), new DateTime(2021, 5, 27, 2, 34, 37, 795, DateTimeKind.Local).AddTicks(9878) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1218), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1226), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1229), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1231), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1234), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1236), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.AddForeignKey(
                name: "FK_DietWekkly_Diets_DietId",
                table: "DietWekkly",
                column: "DietId",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
