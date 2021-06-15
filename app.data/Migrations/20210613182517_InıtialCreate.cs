using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class InıtialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "packageRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packageRequests", x => x.Id);
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
                name: "Diets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartingWeight = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    StartingWaistline = table.Column<int>(type: "int", nullable: false),
                    StartingBreastSize = table.Column<int>(type: "int", nullable: false),
                    RemainingPackages = table.Column<int>(type: "int", nullable: false),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diets_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pilateis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RemainingPackages = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pilateis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pilateis_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnamnezForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DietId = table.Column<int>(type: "int", nullable: false),
                    Soru1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru16 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru17 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru18 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru19 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soru20 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    morning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Snack1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Snack2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Evening = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    snack3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    water = table.Column<int>(type: "int", nullable: true),
                    Tea = table.Column<int>(type: "int", nullable: true),
                    Coffea = table.Column<int>(type: "int", nullable: true),
                    Soda = table.Column<int>(type: "int", nullable: true),
                    HerbalTea = table.Column<int>(type: "int", nullable: true),
                    Alkol = table.Column<int>(type: "int", nullable: true),
                    Juice = table.Column<int>(type: "int", nullable: true),
                    Cola = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnamnezForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnamnezForms_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
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
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    GivedDate = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietWekklies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietWekklies_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DietMenüs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    TwoMeals = table.Column<bool>(type: "bit", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    DietWekklyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietMenüs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietMenüs_DietWekklies_DietWekklyId",
                        column: x => x.DietWekklyId,
                        principalTable: "DietWekklies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentMounth = table.Column<int>(type: "int", nullable: false),
                    CurrentDay = table.Column<int>(type: "int", nullable: false),
                    CurrentHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingHour = table.Column<int>(type: "int", nullable: false),
                    FinishedHour = table.Column<int>(type: "int", nullable: false),
                    DietWekklyId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hours_DietWekklies_DietWekklyId",
                        column: x => x.DietWekklyId,
                        principalTable: "DietWekklies",
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

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Mail", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { 1, "Dilek", true, "Karaca", "dlk@gmail.com", "5524673747", "asdad" },
                    { 2, "Sinem", true, "Karaca", "dlk@gmail.com", "5524673747", "asdad" },
                    { 3, "Muammer", false, "Karaca", "dlk@gmail.com", "5524673747", "asdad" },
                    { 4, "Ercan", false, "Karaca", "dlk@gmail.com", "5524673747", "asdad" },
                    { 5, "Mustafa", false, "Karaca", "dlk@gmail.com", "5524673747", "asdad" },
                    { 6, "Sercan", false, "Karaca", "dlk@gmail.com", "5524673747", "asdad" },
                    { 7, "Güven", false, "Karaca", "dlk@gmail.com", "5524673747", "asdad" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Active", "Name" },
                values: new object[,]
                {
                    { 1, true, "Salata Tarifi" },
                    { 2, true, "Kabak Tarifi" },
                    { 3, true, "Tuzlu Tarifi" },
                    { 4, true, "Omlet Tarifi" },
                    { 5, true, "Su Tarifi" },
                    { 6, true, "Kahve Tarifi" },
                    { 7, true, "Karnıbahar Tarifi" }
                });

            migrationBuilder.InsertData(
                table: "Diets",
                columns: new[] { "Id", "CustomerId", "DateEnd", "DateStart", "Height", "RemainingPackages", "StartingBreastSize", "StartingWaistline", "StartingWeight" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 6, 13, 21, 25, 17, 21, DateTimeKind.Local).AddTicks(8498), new DateTime(2021, 6, 13, 21, 25, 17, 22, DateTimeKind.Local).AddTicks(9651), 168, 0, 84, 90, 80 },
                    { 2, 2, new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2306), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2314), 168, 0, 84, 90, 80 },
                    { 3, 3, new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2317), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2318), 168, 0, 84, 90, 80 },
                    { 4, 4, new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2320), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2321), 168, 0, 84, 90, 80 },
                    { 5, 5, new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2323), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2324), 168, 0, 84, 90, 80 },
                    { 6, 6, new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2326), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2327), 168, 0, 84, 90, 80 },
                    { 7, 7, new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2328), new DateTime(2021, 6, 13, 21, 25, 17, 23, DateTimeKind.Local).AddTicks(2330), 168, 0, 84, 90, 80 }
                });

            migrationBuilder.InsertData(
                table: "Pilateis",
                columns: new[] { "Id", "CustomerId", "DateStart", "Name", "RemainingPackages" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(1788), null, 8 },
                    { 2, 2, new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3148), null, 8 },
                    { 3, 3, new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3155), null, 8 },
                    { 4, 4, new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3157), null, 8 },
                    { 5, 5, new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3158), null, 8 },
                    { 6, 6, new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3160), null, 8 },
                    { 7, 7, new DateTime(2021, 6, 13, 21, 25, 17, 31, DateTimeKind.Local).AddTicks(3162), null, 8 }
                });

            migrationBuilder.InsertData(
                table: "CombineDietRecipe",
                columns: new[] { "DietId", "RecipeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 2, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "DietWekklies",
                columns: new[] { "Id", "Active", "AvgNmbrOfSteps", "AvgWater", "CurrentBreastSize", "CurrentWaistline", "CurrentWeight", "DateTime", "Detox", "DietId", "DietImplementation", "GivedDate", "Name" },
                values: new object[,]
                {
                    { 1, true, 2500, 2.5, 70, 80, 80, null, true, 1, 4, false, "1. Hafta" },
                    { 2, true, 2700, 2.0, 68, 79, 78, null, true, 1, 3, false, "2. Hafta" },
                    { 3, true, 2300, 3.0, 67, 76, 75, null, true, 1, 2, false, "3. Hafta" },
                    { 4, true, 200, 2.0, 65, 75, 60, null, true, 1, 5, false, "4. Hafta" },
                    { 5, false, 2500, 2.5, 70, 80, 80, null, true, 2, 4, false, "1. Hafta" },
                    { 6, false, 2700, 2.0, 68, 79, 78, null, true, 2, 3, false, "2. Hafta" },
                    { 7, false, 2300, 3.0, 67, 76, 75, null, true, 2, 2, false, "3. Hafta" },
                    { 8, false, 200, 2.0, 65, 75, 60, null, true, 2, 5, false, "4. Hafta" },
                    { 9, false, 2500, 2.5, 70, 80, 80, null, true, 3, 4, false, "1. Hafta" },
                    { 10, false, 2700, 2.0, 68, 79, 78, null, true, 3, 3, false, "2. Hafta" }
                });

            migrationBuilder.InsertData(
                table: "DietMenüs",
                columns: new[] { "Id", "DietWekklyId", "FullName", "Gender", "Path", "TwoMeals", "Weight" },
                values: new object[,]
                {
                    { 1, 1, "Muammer Karaca", false, null, false, 80 },
                    { 2, 2, "Sinem Karaca", true, null, false, 80 },
                    { 3, 3, "Muammer Karaca", false, null, false, 65 },
                    { 4, 4, "Sinem Karaca", true, null, false, 75 },
                    { 5, 5, "Muammer Karaca", true, null, true, 80 },
                    { 6, 6, "Dilek Karaca", false, null, true, 60 },
                    { 7, 7, "Sercan Karaca", false, null, true, 65 },
                    { 8, 8, "Muammer Karaca", true, null, false, 80 },
                    { 9, 9, "Muammer Karaca", true, null, true, 70 },
                    { 10, 10, "Sercan Karaca", true, null, false, 80 }
                });

            migrationBuilder.InsertData(
                table: "CombineDietMenüRecipe",
                columns: new[] { "DietMenüId", "RecipeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 4 },
                    { 3, 1 },
                    { 4, 6 },
                    { 5, 4 },
                    { 5, 7 },
                    { 5, 5 },
                    { 6, 5 },
                    { 6, 7 },
                    { 7, 6 },
                    { 8, 4 },
                    { 8, 3 },
                    { 9, 1 },
                    { 10, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnamnezForms_DietId",
                table: "AnamnezForms",
                column: "DietId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CombineDietMenüRecipe_DietMenüId",
                table: "CombineDietMenüRecipe",
                column: "DietMenüId");

            migrationBuilder.CreateIndex(
                name: "IX_CombineDietRecipe_RecipeId",
                table: "CombineDietRecipe",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_DietMenüs_DietWekklyId",
                table: "DietMenüs",
                column: "DietWekklyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diets_CustomerId",
                table: "Diets",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DietWekklies_DietId",
                table: "DietWekklies",
                column: "DietId");

            migrationBuilder.CreateIndex(
                name: "IX_Hours_DietWekklyId",
                table: "Hours",
                column: "DietWekklyId",
                unique: true,
                filter: "[DietWekklyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Pilateis_CustomerId",
                table: "Pilateis",
                column: "CustomerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnamnezForms");

            migrationBuilder.DropTable(
                name: "CombineDietMenüRecipe");

            migrationBuilder.DropTable(
                name: "CombineDietRecipe");

            migrationBuilder.DropTable(
                name: "Hours");

            migrationBuilder.DropTable(
                name: "packageRequests");

            migrationBuilder.DropTable(
                name: "Pilateis");

            migrationBuilder.DropTable(
                name: "DietMenüs");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "DietWekklies");

            migrationBuilder.DropTable(
                name: "Diets");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
