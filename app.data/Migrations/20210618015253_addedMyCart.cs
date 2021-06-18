using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class addedMyCart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    PaidType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyCarts_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyCarts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 4, 52, 52, 836, DateTimeKind.Local).AddTicks(5816), new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(4495) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6025), new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6031) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6033), new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6034) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6036), new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6038), new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6041), new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6043), new DateTime(2021, 6, 18, 4, 52, 52, 837, DateTimeKind.Local).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 4, 52, 52, 840, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 4, 52, 52, 840, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 4, 52, 52, 840, DateTimeKind.Local).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 4, 52, 52, 840, DateTimeKind.Local).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 4, 52, 52, 840, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 4, 52, 52, 840, DateTimeKind.Local).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 18, 4, 52, 52, 840, DateTimeKind.Local).AddTicks(9124));

            migrationBuilder.CreateIndex(
                name: "IX_MyCarts_CustomerId",
                table: "MyCarts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_MyCarts_ProductId",
                table: "MyCarts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyCarts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

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
    }
}
