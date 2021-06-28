using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class Otheaars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "GüncelKilo",
                table: "DietWekklies",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "GüncelKalca",
                table: "DietWekklies",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "GüncelGögüs",
                table: "DietWekklies",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "GüncelBel",
                table: "DietWekklies",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Dietuyumluluk",
                table: "DietWekklies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "GüncelKilo",
                table: "DietWekklies",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "GüncelKalca",
                table: "DietWekklies",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "GüncelGögüs",
                table: "DietWekklies",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "GüncelBel",
                table: "DietWekklies",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "Dietuyumluluk",
                table: "DietWekklies",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
