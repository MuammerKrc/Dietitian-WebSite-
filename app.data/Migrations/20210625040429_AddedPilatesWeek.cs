using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class AddedPilatesWeek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateStart",
                table: "Pilateis");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pilateis");

            migrationBuilder.DropColumn(
                name: "DateStart",
                table: "Diets");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Pilateis",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Diets",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Traning",
                table: "Calendars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeOfDate",
                table: "Calendars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "PilatesWeekId",
                table: "Calendars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PilatesWeeks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDone = table.Column<bool>(type: "bit", nullable: false),
                    PilatesId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Calendars_PilatesWeekId",
                table: "Calendars",
                column: "PilatesWeekId",
                unique: true,
                filter: "[PilatesWeekId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PilatesWeeks_PilatesId",
                table: "PilatesWeeks",
                column: "PilatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calendars_PilatesWeeks_PilatesWeekId",
                table: "Calendars",
                column: "PilatesWeekId",
                principalTable: "PilatesWeeks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calendars_PilatesWeeks_PilatesWeekId",
                table: "Calendars");

            migrationBuilder.DropTable(
                name: "PilatesWeeks");

            migrationBuilder.DropIndex(
                name: "IX_Calendars_PilatesWeekId",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Pilateis");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Diets");

            migrationBuilder.DropColumn(
                name: "DateTimeOfDate",
                table: "Calendars");

            migrationBuilder.DropColumn(
                name: "PilatesWeekId",
                table: "Calendars");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStart",
                table: "Pilateis",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pilateis",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStart",
                table: "Diets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Traning",
                table: "Calendars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
