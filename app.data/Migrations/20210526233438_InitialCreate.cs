using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Diets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingWeight = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    StartingWaistline = table.Column<int>(type: "int", nullable: false),
                    StartingBreastSize = table.Column<int>(type: "int", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menü",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenüName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gived1 = table.Column<bool>(type: "bit", nullable: false),
                    MenüName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gived2 = table.Column<bool>(type: "bit", nullable: false),
                    MenüName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gived3 = table.Column<bool>(type: "bit", nullable: false),
                    MenüName4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gived4 = table.Column<bool>(type: "bit", nullable: false),
                    MenüName5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gived5 = table.Column<bool>(type: "bit", nullable: false),
                    MenüName6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gived6 = table.Column<bool>(type: "bit", nullable: false),
                    MenüName7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gived7 = table.Column<bool>(type: "bit", nullable: false),
                    MenüName8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gived8 = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menü", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pilateis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RemainingPackages = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilateis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DietWekkly",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentWeight = table.Column<int>(type: "int", nullable: false),
                    CurrentWaistline = table.Column<int>(type: "int", nullable: false),
                    CurrentBreastSize = table.Column<int>(type: "int", nullable: false),
                    DietImplementation = table.Column<int>(type: "int", nullable: false),
                    AvgWater = table.Column<double>(type: "float", nullable: false),
                    AvgNmbrOfSteps = table.Column<int>(type: "int", nullable: false),
                    DietId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietWekkly", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietWekkly_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DietId = table.Column<int>(type: "int", nullable: false),
                    PilatesId = table.Column<int>(type: "int", nullable: false),
                    MenüID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Menü_MenüID",
                        column: x => x.MenüID,
                        principalTable: "Menü",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Customers_Pilateis_PilatesId",
                        column: x => x.PilatesId,
                        principalTable: "Pilateis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Diets",
                columns: new[] { "Id", "DateEnd", "DateStart", "Height", "StartingBreastSize", "StartingWaistline", "StartingWeight" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 27, 2, 34, 37, 795, DateTimeKind.Local).AddTicks(1035), new DateTime(2021, 5, 27, 2, 34, 37, 795, DateTimeKind.Local).AddTicks(9878), 168, 84, 90, 80 },
                    { 2, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1218), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1223), 168, 84, 90, 80 },
                    { 3, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1226), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1227), 168, 84, 90, 80 },
                    { 4, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1229), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1230), 168, 84, 90, 80 },
                    { 5, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1231), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1232), 168, 84, 90, 80 },
                    { 6, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1234), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1235), 168, 84, 90, 80 },
                    { 7, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1236), new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(1237), 168, 84, 90, 80 }
                });

            migrationBuilder.InsertData(
                table: "Menü",
                columns: new[] { "Id", "Gived1", "Gived2", "Gived3", "Gived4", "Gived5", "Gived6", "Gived7", "Gived8", "MenüName1", "MenüName2", "MenüName3", "MenüName4", "MenüName5", "MenüName6", "MenüName7", "MenüName8" },
                values: new object[,]
                {
                    { 7, false, true, false, true, false, false, false, false, "menü1", "menü2", "menü3", "menü4", "menü5", "menü6", "menü7", "menü8" },
                    { 6, false, false, false, false, false, false, false, false, "menü1", "menü2", "menü3", "menü4", "menü5", "menü6", "menü7", "menü8" },
                    { 5, false, false, true, false, false, false, false, false, "menü1", "menü2", "menü3", "menü4", "menü5", "menü6", "menü7", "menü8" },
                    { 4, false, true, false, false, false, false, false, false, "menü1", "menü2", "menü3", "menü4", "menü5", "menü6", "menü7", "menü8" },
                    { 3, true, false, false, false, false, false, false, false, "menü1", "menü2", "menü3", "menü4", "menü5", "menü6", "menü7", "menü8" },
                    { 2, true, false, false, false, false, false, false, false, "menü1", "menü2", "menü3", "menü4", "menü5", "menü6", "menü7", "menü8" },
                    { 1, false, false, false, false, false, false, false, false, "menü1", "menü2", "menü3", "menü4", "menü5", "menü6", "menü7", "menü8" }
                });

            migrationBuilder.InsertData(
                table: "Pilateis",
                columns: new[] { "Id", "DateStart", "Name", "RemainingPackages" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(4881), null, 8 },
                    { 2, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5475), null, 8 },
                    { 3, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5480), null, 8 },
                    { 4, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5481), null, 8 },
                    { 5, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5483), null, 8 },
                    { 6, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5484), null, 8 },
                    { 7, new DateTime(2021, 5, 27, 2, 34, 37, 796, DateTimeKind.Local).AddTicks(5486), null, 8 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "DietId", "FirstName", "LastName", "Mail", "MenüID", "PhoneNumber", "PilatesId", "UserId" },
                values: new object[,]
                {
                    { 7, 7, "Güven", "Karaca", "dlk@gmail.com", 7, "5524673747", 7, "asdad" },
                    { 5, 5, "Mustafa", "Karaca", "dlk@gmail.com", 5, "5524673747", 5, "asdad" },
                    { 4, 4, "Ercan", "Karaca", "dlk@gmail.com", 4, "5524673747", 4, "asdad" },
                    { 3, 3, "Muammer", "Karaca", "dlk@gmail.com", 3, "5524673747", 3, "asdad" },
                    { 2, 2, "Sinem", "Karaca", "dlk@gmail.com", 2, "5524673747", 2, "asdad" },
                    { 1, 1, "Dilek", "Karaca", "dlk@gmail.com", 1, "5524673747", 1, "asdad" },
                    { 6, 6, "Sercan", "Karaca", "dlk@gmail.com", 6, "5524673747", 6, "asdad" }
                });

            migrationBuilder.InsertData(
                table: "DietWekkly",
                columns: new[] { "Id", "AvgNmbrOfSteps", "AvgWater", "CurrentBreastSize", "CurrentWaistline", "CurrentWeight", "DietId", "DietImplementation" },
                values: new object[,]
                {
                    { 16, 200, 2.0, 65, 75, 60, 5, 5 },
                    { 15, 2300, 3.0, 67, 76, 75, 5, 2 },
                    { 14, 2700, 2.0, 68, 79, 78, 5, 3 },
                    { 13, 2500, 2.5, 70, 80, 80, 4, 4 },
                    { 12, 200, 2.0, 65, 75, 60, 4, 5 },
                    { 10, 2700, 2.0, 68, 79, 78, 3, 3 },
                    { 9, 2500, 2.5, 70, 80, 80, 3, 4 },
                    { 8, 200, 2.0, 65, 75, 60, 2, 5 },
                    { 7, 2300, 3.0, 67, 76, 75, 2, 2 },
                    { 6, 2700, 2.0, 68, 79, 78, 2, 3 },
                    { 5, 2500, 2.5, 70, 80, 80, 2, 4 },
                    { 4, 200, 2.0, 65, 75, 60, 1, 5 },
                    { 3, 2300, 3.0, 67, 76, 75, 1, 2 },
                    { 2, 2700, 2.0, 68, 79, 78, 1, 3 },
                    { 11, 2300, 3.0, 67, 76, 75, 4, 2 },
                    { 1, 2500, 2.5, 70, 80, 80, 1, 4 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_DietWekkly_DietId",
                table: "DietWekkly",
                column: "DietId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DietWekkly");

            migrationBuilder.DropTable(
                name: "Menü");

            migrationBuilder.DropTable(
                name: "Pilateis");

            migrationBuilder.DropTable(
                name: "Diets");
        }
    }
}
