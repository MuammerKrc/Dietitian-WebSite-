using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietMenüs_DietWekklies_dietWekklyId",
                table: "DietMenüs");

            migrationBuilder.RenameColumn(
                name: "dietWekklyId",
                table: "DietMenüs",
                newName: "DietWekklyId");

            migrationBuilder.RenameIndex(
                name: "IX_DietMenüs_dietWekklyId",
                table: "DietMenüs",
                newName: "IX_DietMenüs_DietWekklyId");

            migrationBuilder.AddForeignKey(
                name: "FK_DietMenüs_DietWekklies_DietWekklyId",
                table: "DietMenüs",
                column: "DietWekklyId",
                principalTable: "DietWekklies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DietMenüs_DietWekklies_DietWekklyId",
                table: "DietMenüs");

            migrationBuilder.RenameColumn(
                name: "DietWekklyId",
                table: "DietMenüs",
                newName: "dietWekklyId");

            migrationBuilder.RenameIndex(
                name: "IX_DietMenüs_DietWekklyId",
                table: "DietMenüs",
                newName: "IX_DietMenüs_dietWekklyId");

            migrationBuilder.AddForeignKey(
                name: "FK_DietMenüs_DietWekklies_dietWekklyId",
                table: "DietMenüs",
                column: "dietWekklyId",
                principalTable: "DietWekklies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
