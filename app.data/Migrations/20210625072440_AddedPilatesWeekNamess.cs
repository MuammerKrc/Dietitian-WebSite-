using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class AddedPilatesWeekNamess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDone",
                table: "DietWekklies",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDone",
                table: "DietWekklies");
        }
    }
}
