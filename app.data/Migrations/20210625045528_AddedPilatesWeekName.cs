using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class AddedPilatesWeekName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PilatesWeeks",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "PilatesWeeks");
        }
    }
}
