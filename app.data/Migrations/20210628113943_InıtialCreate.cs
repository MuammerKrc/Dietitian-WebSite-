using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class InıtialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    RemaningDietPackages = table.Column<int>(nullable: false),
                    RemaningPilatesPackages = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "dateRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeekId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    RequestTİme = table.Column<DateTime>(nullable: false),
                    typeOfRequest = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dateRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralMesajs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    href = table.Column<bool>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    AlertType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralMesajs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "packageRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    RequestTime = table.Column<DateTime>(nullable: false),
                    typeOfRequest = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_packageRequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(nullable: true),
                    IsPaid = table.Column<bool>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    PaidType = table.Column<string>(nullable: true),
                    Time = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Active = table.Column<bool>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DietId = table.Column<int>(nullable: false),
                    Yas = table.Column<float>(nullable: true),
                    Boy = table.Column<float>(nullable: true),
                    Kilo = table.Column<float>(nullable: true),
                    BasenÖlcüsü = table.Column<float>(nullable: true),
                    BelÖlcüsü = table.Column<float>(nullable: true),
                    GögüsÖlcüsü = table.Column<float>(nullable: true),
                    Soru1 = table.Column<string>(nullable: true),
                    Soru2 = table.Column<string>(nullable: true),
                    Soru3 = table.Column<string>(nullable: true),
                    Soru4 = table.Column<string>(nullable: true),
                    Soru5 = table.Column<string>(nullable: true),
                    Soru6 = table.Column<string>(nullable: true),
                    Soru7 = table.Column<string>(nullable: true),
                    Soru8 = table.Column<string>(nullable: true),
                    Soru9 = table.Column<string>(nullable: true),
                    Soru10 = table.Column<string>(nullable: true),
                    Soru11 = table.Column<string>(nullable: true),
                    Soru12 = table.Column<string>(nullable: true),
                    Soru13 = table.Column<string>(nullable: true),
                    Soru14 = table.Column<string>(nullable: true),
                    Soru15 = table.Column<string>(nullable: true),
                    Soru16 = table.Column<string>(nullable: true),
                    Soru17 = table.Column<int>(nullable: true),
                    Soru18 = table.Column<int>(nullable: true),
                    Soru19 = table.Column<int>(nullable: true),
                    Soru20 = table.Column<int>(nullable: true),
                    Soru21 = table.Column<int>(nullable: true),
                    Soru22 = table.Column<int>(nullable: true),
                    Soru23 = table.Column<int>(nullable: true),
                    Soru24 = table.Column<int>(nullable: true),
                    Soru25 = table.Column<string>(nullable: true),
                    Soru26 = table.Column<string>(nullable: true),
                    Soru27 = table.Column<string>(nullable: true),
                    Soru28 = table.Column<string>(nullable: true),
                    Soru29 = table.Column<string>(nullable: true),
                    Soru30 = table.Column<string>(nullable: true)
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
                    DietId = table.Column<int>(nullable: false),
                    RecipeId = table.Column<int>(nullable: false)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GüncelKilo = table.Column<float>(nullable: false),
                    GüncelBel = table.Column<float>(nullable: false),
                    GüncelKalca = table.Column<float>(nullable: false),
                    GüncelGögüs = table.Column<float>(nullable: false),
                    Dietuyumluluk = table.Column<int>(nullable: false),
                    ortSu = table.Column<int>(nullable: false),
                    ortalamaAdim = table.Column<int>(nullable: false),
                    Detox = table.Column<bool>(nullable: false),
                    DietId = table.Column<int>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    IsUpdate = table.Column<bool>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false),
                    GivedDate = table.Column<bool>(nullable: false),
                    DateTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DietWekklies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DietWekklies_Diets_DietId",
                        column: x => x.DietId,
                        principalTable: "Diets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PilatesWeeks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsDone = table.Column<bool>(nullable: false),
                    PilatesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PilatesWeeks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PilatesWeeks_Pilateis_PilatesId",
                        column: x => x.PilatesId,
                        principalTable: "Pilateis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DietMenüs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    TwoMeals = table.Column<bool>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    DietWekklyId = table.Column<int>(nullable: false)
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
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentYear = table.Column<int>(nullable: false),
                    CurrentMounth = table.Column<int>(nullable: false),
                    CurrentDay = table.Column<int>(nullable: false),
                    CurrentHour = table.Column<string>(nullable: true),
                    StartingHour = table.Column<int>(nullable: false),
                    FinishedHour = table.Column<int>(nullable: false),
                    Traning = table.Column<int>(nullable: false),
                    DietWekklyId = table.Column<int>(nullable: true),
                    PilatesWeekId = table.Column<int>(nullable: true),
                    DateTimeOfDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Calendars_PilatesWeeks_PilatesWeekId",
                        column: x => x.PilatesWeekId,
                        principalTable: "PilatesWeeks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CombineDietMenüRecipe",
                columns: table => new
                {
                    DietMenüId = table.Column<int>(nullable: false),
                    RecipeId = table.Column<int>(nullable: false)
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
                name: "IX_Calendars_PilatesWeekId",
                table: "Calendars",
                column: "PilatesWeekId",
                unique: true,
                filter: "[PilatesWeekId] IS NOT NULL");

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
                name: "IX_MyCarts_CustomerId",
                table: "MyCarts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Pilateis_CustomerId",
                table: "Pilateis",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PilatesWeeks_PilatesId",
                table: "PilatesWeeks",
                column: "PilatesId");

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
                name: "packageRequests");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PilatesWeeks");

            migrationBuilder.DropTable(
                name: "DietMenüs");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Pilateis");

            migrationBuilder.DropTable(
                name: "DietWekklies");

            migrationBuilder.DropTable(
                name: "Diets");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
