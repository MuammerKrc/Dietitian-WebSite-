using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class AddedGeneralMesaj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneralMesajs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    href = table.Column<bool>(type: "bit", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlertType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralMesajs", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralMesajs");

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
    }
}
