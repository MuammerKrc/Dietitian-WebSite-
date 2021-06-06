using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnamnezForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietMenüs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mounths",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentMounth = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mounths", x => x.Id);
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
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnamnezFormId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diets_AnamnezForms_AnamnezFormId",
                        column: x => x.AnamnezFormId,
                        principalTable: "AnamnezForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MounthId = table.Column<int>(type: "int", nullable: true),
                    CurrentDay = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Days_Mounths_MounthId",
                        column: x => x.MounthId,
                        principalTable: "Mounths",
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
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    GivedDate = table.Column<bool>(type: "bit", nullable: false),
                    DateTime = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Hours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingHour = table.Column<int>(type: "int", nullable: false),
                    FinishedHour = table.Column<int>(type: "int", nullable: false),
                    DietWekklyId = table.Column<int>(type: "int", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hours_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hours_DietWekklies_DietWekklyId",
                        column: x => x.DietWekklyId,
                        principalTable: "DietWekklies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DietMenüs",
                columns: new[] { "Id", "FullName", "Gender", "Path", "TwoMeals", "Weight" },
                values: new object[,]
                {
                    { 9, "Muammer Karaca", true, null, true, 70 },
                    { 10, "Sercan Karaca", true, null, false, 80 },
                    { 8, "Muammer Karaca", true, null, false, 80 },
                    { 7, "Sercan Karaca", false, null, true, 65 },
                    { 6, "Dilek Karaca", false, null, true, 60 },
                    { 5, "Muammer Karaca", true, null, true, 80 },
                    { 4, "Sinem Karaca", true, null, false, 75 },
                    { 1, "Muammer Karaca", false, null, false, 80 },
                    { 2, "Sinem Karaca", true, null, false, 80 },
                    { 3, "Muammer Karaca", false, null, false, 65 }
                });

            migrationBuilder.InsertData(
                table: "Diets",
                columns: new[] { "Id", "AnamnezFormId", "DateEnd", "DateStart", "Height", "StartingBreastSize", "StartingWaistline", "StartingWeight" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 6, 3, 18, 45, 26, 800, DateTimeKind.Local).AddTicks(7531), new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(6001), 168, 84, 90, 80 },
                    { 6, null, new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7264), new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7265), 168, 84, 90, 80 },
                    { 5, null, new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7261), new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7262), 168, 84, 90, 80 },
                    { 4, null, new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7259), new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7260), 168, 84, 90, 80 },
                    { 3, null, new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7256), new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7258), 168, 84, 90, 80 },
                    { 2, null, new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7250), new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7254), 168, 84, 90, 80 },
                    { 7, null, new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7266), new DateTime(2021, 6, 3, 18, 45, 26, 801, DateTimeKind.Local).AddTicks(7267), 168, 84, 90, 80 }
                });

            migrationBuilder.InsertData(
                table: "Pilateis",
                columns: new[] { "Id", "DateStart", "Name", "RemainingPackages" },
                values: new object[,]
                {
                    { 7, new DateTime(2021, 6, 3, 18, 45, 26, 807, DateTimeKind.Local).AddTicks(4583), null, 8 },
                    { 6, new DateTime(2021, 6, 3, 18, 45, 26, 807, DateTimeKind.Local).AddTicks(4581), null, 8 },
                    { 5, new DateTime(2021, 6, 3, 18, 45, 26, 807, DateTimeKind.Local).AddTicks(4580), null, 8 },
                    { 4, new DateTime(2021, 6, 3, 18, 45, 26, 807, DateTimeKind.Local).AddTicks(4578), null, 8 },
                    { 2, new DateTime(2021, 6, 3, 18, 45, 26, 807, DateTimeKind.Local).AddTicks(4572), null, 8 },
                    { 1, new DateTime(2021, 6, 3, 18, 45, 26, 807, DateTimeKind.Local).AddTicks(3963), null, 8 },
                    { 3, new DateTime(2021, 6, 3, 18, 45, 26, 807, DateTimeKind.Local).AddTicks(4577), null, 8 }
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
                    { 3, 1 },
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
                    { 5, 7 },
                    { 1, 1 },
                    { 6, 7 }
                });

            migrationBuilder.InsertData(
                table: "CombineDietRecipe",
                columns: new[] { "DietId", "RecipeId" },
                values: new object[,]
                {
                    { 2, 4 },
                    { 1, 3 },
                    { 2, 2 },
                    { 1, 2 },
                    { 1, 1 },
                    { 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "DietId", "FirstName", "Gender", "LastName", "Mail", "PhoneNumber", "PilatesId", "UserId" },
                values: new object[,]
                {
                    { 5, 5, "Mustafa", false, "Karaca", "dlk@gmail.com", "5524673747", 5, "asdad" },
                    { 6, 6, "Sercan", false, "Karaca", "dlk@gmail.com", "5524673747", 6, "asdad" },
                    { 2, 2, "Sinem", true, "Karaca", "dlk@gmail.com", "5524673747", 2, "asdad" },
                    { 3, 3, "Muammer", false, "Karaca", "dlk@gmail.com", "5524673747", 3, "asdad" },
                    { 4, 4, "Ercan", false, "Karaca", "dlk@gmail.com", "5524673747", 4, "asdad" },
                    { 7, 7, "Güven", false, "Karaca", "dlk@gmail.com", "5524673747", 7, "asdad" },
                    { 1, 1, "Dilek", true, "Karaca", "dlk@gmail.com", "5524673747", 1, "asdad" }
                });

            migrationBuilder.InsertData(
                table: "DietWekklies",
                columns: new[] { "Id", "Active", "AvgNmbrOfSteps", "AvgWater", "CurrentBreastSize", "CurrentWaistline", "CurrentWeight", "DateTime", "Detox", "DietId", "DietImplementation", "DietMenüId", "GivedDate", "Name" },
                values: new object[,]
                {
                    { 5, false, 2500, 2.5, 70, 80, 80, null, true, 2, 4, 5, false, "1. Hafta" },
                    { 3, true, 2300, 3.0, 67, 76, 75, null, true, 1, 2, 3, false, "3. Hafta" },
                    { 4, true, 200, 2.0, 65, 75, 60, null, true, 1, 5, 4, false, "4. Hafta" },
                    { 2, true, 2700, 2.0, 68, 79, 78, null, true, 1, 3, 2, false, "2. Hafta" },
                    { 9, false, 2500, 2.5, 70, 80, 80, null, true, 3, 4, 9, false, "1. Hafta" },
                    { 7, false, 2300, 3.0, 67, 76, 75, null, true, 2, 2, 7, false, "3. Hafta" },
                    { 8, false, 200, 2.0, 65, 75, 60, null, true, 2, 5, 8, false, "4. Hafta" },
                    { 10, false, 2700, 2.0, 68, 79, 78, null, true, 3, 3, 10, false, "2. Hafta" },
                    { 6, false, 2700, 2.0, 68, 79, 78, null, true, 2, 3, 6, false, "2. Hafta" },
                    { 1, true, 2500, 2.5, 70, 80, 80, null, true, 1, 4, 1, false, "1. Hafta" }
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
                name: "IX_Days_MounthId",
                table: "Days",
                column: "MounthId");

            migrationBuilder.CreateIndex(
                name: "IX_Diets_AnamnezFormId",
                table: "Diets",
                column: "AnamnezFormId",
                unique: true,
                filter: "[AnamnezFormId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DietWekklies_DietId",
                table: "DietWekklies",
                column: "DietId");

            migrationBuilder.CreateIndex(
                name: "IX_DietWekklies_DietMenüId",
                table: "DietWekklies",
                column: "DietMenüId");

            migrationBuilder.CreateIndex(
                name: "IX_Hours_DayId",
                table: "Hours",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Hours_DietWekklyId",
                table: "Hours",
                column: "DietWekklyId",
                unique: true,
                filter: "[DietWekklyId] IS NOT NULL");
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
                name: "Hours");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Pilateis");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "DietWekklies");

            migrationBuilder.DropTable(
                name: "Mounths");

            migrationBuilder.DropTable(
                name: "DietMenüs");

            migrationBuilder.DropTable(
                name: "Diets");

            migrationBuilder.DropTable(
                name: "AnamnezForms");
        }
    }
}
