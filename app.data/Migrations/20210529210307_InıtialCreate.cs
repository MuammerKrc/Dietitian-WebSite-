using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class InıtialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DietMenüs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    TwoMeals = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietMenüs", x => x.Id);
                });

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
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DietWekklies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentWeight = table.Column<int>(type: "int", nullable: false),
                    CurrentWaistline = table.Column<int>(type: "int", nullable: false),
                    CurrentBreastSize = table.Column<int>(type: "int", nullable: false),
                    DietImplementation = table.Column<int>(type: "int", nullable: false),
                    AvgWater = table.Column<double>(type: "float", nullable: false),
                    AvgNmbrOfSteps = table.Column<int>(type: "int", nullable: false),
                    Detox = table.Column<bool>(type: "bit", nullable: false),
                    DietId = table.Column<int>(type: "int", nullable: true),
                    DietMenüId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietWekklies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietWekklies_DietMenüs_DietMenüId",
                        column: x => x.DietMenüId,
                        principalTable: "DietMenüs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DietWekklies_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    DietId = table.Column<int>(type: "int", nullable: true),
                    PilatesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Pilateis_PilatesId",
                        column: x => x.PilatesId,
                        principalTable: "Pilateis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CombineDietMenüRecipe",
                columns: table => new
                {
                    DietMenüId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombineDietMenüRecipe", x => new { x.RecipeId, x.DietMenüId });
                    table.ForeignKey(
                        name: "FK_CombineDietMenüRecipe_DietMenüs_DietMenüId",
                        column: x => x.DietMenüId,
                        principalTable: "DietMenüs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombineDietMenüRecipe_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CombineDietRecipe",
                columns: table => new
                {
                    DietId = table.Column<int>(type: "int", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombineDietRecipe", x => new { x.DietId, x.RecipeId });
                    table.ForeignKey(
                        name: "FK_CombineDietRecipe_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CombineDietRecipe_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DietMenüs",
                columns: new[] { "Id", "Gender", "Path", "TwoMeals", "Weight" },
                values: new object[,]
                {
                    { 9, true, null, true, 70 },
                    { 10, true, null, false, 80 },
                    { 8, true, null, false, 80 },
                    { 7, false, null, true, 65 },
                    { 6, false, null, true, 60 },
                    { 5, true, null, true, 80 },
                    { 4, true, null, false, 75 },
                    { 1, false, null, false, 80 },
                    { 2, true, null, false, 80 },
                    { 3, false, null, false, 65 }
                });

            migrationBuilder.InsertData(
                table: "Diets",
                columns: new[] { "Id", "DateEnd", "DateStart", "Height", "StartingBreastSize", "StartingWaistline", "StartingWeight" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 30, 0, 3, 7, 304, DateTimeKind.Local).AddTicks(3634), new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(3068), 168, 84, 90, 80 },
                    { 6, new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4331), new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4332), 168, 84, 90, 80 },
                    { 5, new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4329), new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4330), 168, 84, 90, 80 },
                    { 4, new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4327), new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4328), 168, 84, 90, 80 },
                    { 3, new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4324), new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4325), 168, 84, 90, 80 },
                    { 2, new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4317), new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4322), 168, 84, 90, 80 },
                    { 7, new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4334), new DateTime(2021, 5, 30, 0, 3, 7, 305, DateTimeKind.Local).AddTicks(4335), 168, 84, 90, 80 }
                });

            migrationBuilder.InsertData(
                table: "Pilateis",
                columns: new[] { "Id", "DateStart", "Name", "RemainingPackages" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 5, 30, 0, 3, 7, 307, DateTimeKind.Local).AddTicks(5844), null, 8 },
                    { 6, new DateTime(2021, 5, 30, 0, 3, 7, 307, DateTimeKind.Local).AddTicks(5843), null, 8 },
                    { 5, new DateTime(2021, 5, 30, 0, 3, 7, 307, DateTimeKind.Local).AddTicks(5842), null, 8 },
                    { 4, new DateTime(2021, 5, 30, 0, 3, 7, 307, DateTimeKind.Local).AddTicks(5840), null, 8 },
                    { 2, new DateTime(2021, 5, 30, 0, 3, 7, 307, DateTimeKind.Local).AddTicks(5835), null, 8 },
                    { 1, new DateTime(2021, 5, 30, 0, 3, 7, 307, DateTimeKind.Local).AddTicks(5260), null, 8 },
                    { 3, new DateTime(2021, 5, 30, 0, 3, 7, 307, DateTimeKind.Local).AddTicks(5839), null, 8 }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Active", "Name" },
                values: new object[,]
                {
                    { 6, true, "Kahve Tarifi" },
                    { 1, true, "Salata Tarifi" },
                    { 2, true, "Kabak Tarifi" },
                    { 3, true, "Tuzlu Tarifi" },
                    { 4, true, "Omlet Tarifi" },
                    { 5, true, "Su Tarifi" },
                    { 7, true, "Karnıbahar Tarifi" }
                });

            migrationBuilder.InsertData(
                table: "CombineDietMenüRecipe",
                columns: new[] { "DietMenüId", "RecipeId" },
                values: new object[,]
                {
                    { 6, 7 },
                    { 7, 6 },
                    { 4, 6 },
                    { 6, 5 },
                    { 5, 5 },
                    { 8, 4 },
                    { 5, 4 },
                    { 2, 4 },
                    { 8, 3 },
                    { 10, 2 },
                    { 1, 2 },
                    { 9, 1 },
                    { 3, 1 },
                    { 1, 1 },
                    { 5, 7 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "DietId", "FirstName", "LastName", "Mail", "PhoneNumber", "PilatesId", "UserId" },
                values: new object[,]
                {
                    { 7, 7, "Güven", "Karaca", "dlk@gmail.com", "5524673747", 7, "asdad" },
                    { 6, 6, "Sercan", "Karaca", "dlk@gmail.com", "5524673747", 6, "asdad" },
                    { 4, 4, "Ercan", "Karaca", "dlk@gmail.com", "5524673747", 4, "asdad" },
                    { 3, 3, "Muammer", "Karaca", "dlk@gmail.com", "5524673747", 3, "asdad" },
                    { 2, 2, "Sinem", "Karaca", "dlk@gmail.com", "5524673747", 2, "asdad" },
                    { 1, 1, "Dilek", "Karaca", "dlk@gmail.com", "5524673747", 1, "asdad" },
                    { 5, 5, "Mustafa", "Karaca", "dlk@gmail.com", "5524673747", 5, "asdad" }
                });

            migrationBuilder.InsertData(
                table: "DietWekklies",
                columns: new[] { "Id", "Active", "AvgNmbrOfSteps", "AvgWater", "CurrentBreastSize", "CurrentWaistline", "CurrentWeight", "Detox", "DietId", "DietImplementation", "DietMenüId", "Name" },
                values: new object[,]
                {
                    { 10, false, 2700, 2.0, 68, 79, 78, true, 3, 3, 10, "2. Hafta" },
                    { 9, false, 2500, 2.5, 70, 80, 80, true, 3, 4, 9, "1. Hafta" },
                    { 8, false, 200, 2.0, 65, 75, 60, true, 2, 5, 8, "4. Hafta" },
                    { 7, false, 2300, 3.0, 67, 76, 75, true, 2, 2, 7, "3. Hafta" },
                    { 6, false, 2700, 2.0, 68, 79, 78, true, 2, 3, 6, "2. Hafta" },
                    { 5, false, 2500, 2.5, 70, 80, 80, true, 2, 4, 5, "1. Hafta" },
                    { 4, true, 200, 2.0, 65, 75, 60, true, 1, 5, 4, "4. Hafta" },
                    { 3, true, 2300, 3.0, 67, 76, 75, true, 1, 2, 3, "3. Hafta" },
                    { 2, true, 2700, 2.0, 68, 79, 78, true, 1, 3, 2, "2. Hafta" },
                    { 1, true, 2500, 2.5, 70, 80, 80, true, 1, 4, 1, "1. Hafta" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CombineDietMenüRecipe_DietMenüId",
                table: "CombineDietMenüRecipe",
                column: "DietMenüId");

            migrationBuilder.CreateIndex(
                name: "IX_CombineDietRecipe_RecipeId",
                table: "CombineDietRecipe",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DietId",
                table: "Customers",
                column: "DietId",
                unique: true,
                filter: "[DietId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PilatesId",
                table: "Customers",
                column: "PilatesId",
                unique: true,
                filter: "[PilatesId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DietWekklies_DietId",
                table: "DietWekklies",
                column: "DietId");

            migrationBuilder.CreateIndex(
                name: "IX_DietWekklies_DietMenüId",
                table: "DietWekklies",
                column: "DietMenüId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CombineDietMenüRecipe");

            migrationBuilder.DropTable(
                name: "CombineDietRecipe");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DietWekklies");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Pilateis");

            migrationBuilder.DropTable(
                name: "DietMenüs");

            migrationBuilder.DropTable(
                name: "Diets");
        }
    }
}
