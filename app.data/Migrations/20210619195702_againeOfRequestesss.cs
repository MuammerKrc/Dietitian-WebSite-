using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class againeOfRequestesss : Migration
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
                    RemaningDietPackages = table.Column<int>(type: "int", nullable: false),
                    RemaningPilatesPackages = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

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
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlertType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralMesajs", x => x.Id);
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
                    typeOfRequest = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
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
                name: "MyCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    PaidType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "Pilateis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "dateRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekId = table.Column<int>(type: "int", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestTİme = table.Column<DateTime>(type: "datetime2", nullable: false),
                    typeOfRequestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dateRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dateRequests_packageRequests_typeOfRequestId",
                        column: x => x.typeOfRequestId,
                        principalTable: "packageRequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentYear = table.Column<int>(type: "int", nullable: false),
                    CurrentMounth = table.Column<int>(type: "int", nullable: false),
                    CurrentDay = table.Column<int>(type: "int", nullable: false),
                    CurrentHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartingHour = table.Column<int>(type: "int", nullable: false),
                    FinishedHour = table.Column<int>(type: "int", nullable: false),
                    Traning = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DietWekklyId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calendars_DietWekklies_DietWekklyId",
                        column: x => x.DietWekklyId,
                        principalTable: "DietWekklies",
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
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                columns: new[] { "Id", "FirstName", "Gender", "LastName", "Mail", "PhoneNumber", "RemaningDietPackages", "RemaningPilatesPackages", "UserId" },
                values: new object[,]
                {
                    { 1, "Dilek", true, "Karaca", "dlk@gmail.com", "5524673747", 0, 0, "asdad" },
                    { 2, "Sinem", true, "Karaca", "dlk@gmail.com", "5524673747", 0, 0, "asdad" },
                    { 3, "Muammer", false, "Karaca", "dlk@gmail.com", "5524673747", 0, 0, "asdad" },
                    { 4, "Ercan", false, "Karaca", "dlk@gmail.com", "5524673747", 0, 0, "asdad" },
                    { 5, "Mustafa", false, "Karaca", "dlk@gmail.com", "5524673747", 0, 0, "asdad" },
                    { 6, "Sercan", false, "Karaca", "dlk@gmail.com", "5524673747", 0, 0, "asdad" },
                    { 7, "Güven", false, "Karaca", "dlk@gmail.com", "5524673747", 0, 0, "asdad" }
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Active", "Content", "Name" },
                values: new object[,]
                {
                    { 1, true, null, "Salata Tarifi" },
                    { 2, true, null, "Kabak Tarifi" },
                    { 3, true, null, "Tuzlu Tarifi" },
                    { 4, true, null, "Omlet Tarifi" },
                    { 5, true, null, "Su Tarifi" },
                    { 6, true, null, "Kahve Tarifi" },
                    { 7, true, null, "Karnıbahar Tarifi" }
                });

            migrationBuilder.InsertData(
                table: "Diets",
                columns: new[] { "Id", "CustomerId", "DateEnd", "DateStart", "Height", "StartingBreastSize", "StartingWaistline", "StartingWeight" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 6, 19, 22, 57, 1, 703, DateTimeKind.Local).AddTicks(1788), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(3433), 168, 84, 90, 80 },
                    { 2, 2, new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5074), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5080), 168, 84, 90, 80 },
                    { 3, 3, new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5082), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5083), 168, 84, 90, 80 },
                    { 4, 4, new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5085), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5086), 168, 84, 90, 80 },
                    { 5, 5, new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5088), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5089), 168, 84, 90, 80 },
                    { 6, 6, new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5090), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5091), 168, 84, 90, 80 },
                    { 7, 7, new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5093), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5094), 168, 84, 90, 80 }
                });

            migrationBuilder.InsertData(
                table: "Pilateis",
                columns: new[] { "Id", "CustomerId", "DateStart", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(4682), null },
                    { 2, 2, new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6530), null },
                    { 3, 3, new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6536), null },
                    { 4, 4, new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6538), null },
                    { 5, 5, new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6539), null },
                    { 6, 6, new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6540), null },
                    { 7, 7, new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6542), null }
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
                columns: new[] { "Id", "Content", "DietWekklyId", "FullName", "Gender", "Path", "TwoMeals", "Weight" },
                values: new object[,]
                {
                    { 1, null, 1, "Muammer Karaca", false, null, false, 80 },
                    { 2, null, 2, "Sinem Karaca", true, null, false, 80 },
                    { 3, null, 3, "Muammer Karaca", false, null, false, 65 },
                    { 4, null, 4, "Sinem Karaca", true, null, false, 75 },
                    { 5, null, 5, "Muammer Karaca", true, null, true, 80 },
                    { 6, null, 6, "Dilek Karaca", false, null, true, 60 },
                    { 7, null, 7, "Sercan Karaca", false, null, true, 65 },
                    { 8, null, 8, "Muammer Karaca", true, null, false, 80 },
                    { 9, null, 9, "Muammer Karaca", true, null, true, 70 },
                    { 10, null, 10, "Sercan Karaca", true, null, false, 80 }
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
                name: "IX_Calendars_DietWekklyId",
                table: "Calendars",
                column: "DietWekklyId",
                unique: true,
                filter: "[DietWekklyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CombineDietMenüRecipe_DietMenüId",
                table: "CombineDietMenüRecipe",
                column: "DietMenüId");

            migrationBuilder.CreateIndex(
                name: "IX_CombineDietRecipe_RecipeId",
                table: "CombineDietRecipe",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_dateRequests_typeOfRequestId",
                table: "dateRequests",
                column: "typeOfRequestId");

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
                name: "IX_MyCarts_CustomerId",
                table: "MyCarts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pilateis_CustomerId",
                table: "Pilateis",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnamnezForms");

            migrationBuilder.DropTable(
                name: "Calendars");

            migrationBuilder.DropTable(
                name: "CombineDietMenüRecipe");

            migrationBuilder.DropTable(
                name: "CombineDietRecipe");

            migrationBuilder.DropTable(
                name: "dateRequests");

            migrationBuilder.DropTable(
                name: "GeneralMesajs");

            migrationBuilder.DropTable(
                name: "MyCarts");

            migrationBuilder.DropTable(
                name: "Pilateis");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "DietMenüs");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "packageRequests");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "DietWekklies");

            migrationBuilder.DropTable(
                name: "Diets");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
