using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class addedDietMenü : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Diets_DietId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Menü_MenüID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Pilateis_PilatesId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_DietWekklies_Diets_DietId",
                table: "DietWekklies");

            migrationBuilder.DropIndex(
                name: "IX_Customers_DietId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MenüID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PilatesId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Menü",
                table: "DietWekklies");

            migrationBuilder.AlterColumn<int>(
                name: "DietId",
                table: "DietWekklies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PilatesId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MenüID",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DietId",
                table: "Customers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "DietMenüs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    dietWekklyId = table.Column<int>(type: "int", nullable: true),
                    TwoMeals = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Recipe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietMenüs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietMenüs_DietWekklies_dietWekklyId",
                        column: x => x.dietWekklyId,
                        principalTable: "DietWekklies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(76), new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9340), new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9347), new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9350), new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9352), new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9354), new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9357), new DateTime(2021, 5, 28, 15, 54, 41, 811, DateTimeKind.Local).AddTicks(9357) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 15, 54, 41, 812, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 15, 54, 41, 812, DateTimeKind.Local).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 15, 54, 41, 812, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 15, 54, 41, 812, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 15, 54, 41, 812, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 15, 54, 41, 812, DateTimeKind.Local).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 5, 28, 15, 54, 41, 812, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DietId",
                table: "Customers",
                column: "DietId",
                unique: true,
                filter: "[DietId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MenüID",
                table: "Customers",
                column: "MenüID",
                unique: true,
                filter: "[MenüID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PilatesId",
                table: "Customers",
                column: "PilatesId",
                unique: true,
                filter: "[PilatesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DietMenüs_dietWekklyId",
                table: "DietMenüs",
                column: "dietWekklyId",
                unique: true,
                filter: "[dietWekklyId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Diets_DietId",
                table: "Customers",
                column: "DietId",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Menü_MenüID",
                table: "Customers",
                column: "MenüID",
                principalTable: "Menü",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Pilateis_PilatesId",
                table: "Customers",
                column: "PilatesId",
                principalTable: "Pilateis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DietWekklies_Diets_DietId",
                table: "DietWekklies",
                column: "DietId",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Diets_DietId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Menü_MenüID",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Pilateis_PilatesId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_DietWekklies_Diets_DietId",
                table: "DietWekklies");

            migrationBuilder.DropTable(
                name: "DietMenüs");

            migrationBuilder.DropIndex(
                name: "IX_Customers_DietId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MenüID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_PilatesId",
                table: "Customers");

            migrationBuilder.AlterColumn<int>(
                name: "DietId",
                table: "DietWekklies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Menü",
                table: "DietWekklies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PilatesId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MenüID",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DietId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DietId",
                table: "Customers",
                column: "DietId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MenüID",
                table: "Customers",
                column: "MenüID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PilatesId",
                table: "Customers",
                column: "PilatesId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Diets_DietId",
                table: "Customers",
                column: "DietId",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Menü_MenüID",
                table: "Customers",
                column: "MenüID",
                principalTable: "Menü",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Pilateis_PilatesId",
                table: "Customers",
                column: "PilatesId",
                principalTable: "Pilateis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DietWekklies_Diets_DietId",
                table: "DietWekklies",
                column: "DietId",
                principalTable: "Diets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
