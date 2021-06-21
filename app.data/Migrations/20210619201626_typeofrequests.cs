using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace app.data.Migrations
{
    public partial class typeofrequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dateRequests_packageRequests_typeOfRequestId",
                table: "dateRequests");

            migrationBuilder.DropIndex(
                name: "IX_dateRequests_typeOfRequestId",
                table: "dateRequests");

            migrationBuilder.DropColumn(
                name: "typeOfRequestId",
                table: "dateRequests");

            migrationBuilder.AddColumn<int>(
                name: "typeOfRequest",
                table: "dateRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 900, DateTimeKind.Local).AddTicks(1929), new DateTime(2021, 6, 19, 23, 16, 25, 900, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1051), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1056) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1058), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1061), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1063), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1065), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1068), new DateTime(2021, 6, 19, 23, 16, 25, 901, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 23, 16, 25, 904, DateTimeKind.Local).AddTicks(3366));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "typeOfRequest",
                table: "dateRequests");

            migrationBuilder.AddColumn<int>(
                name: "typeOfRequestId",
                table: "dateRequests",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 22, 57, 1, 703, DateTimeKind.Local).AddTicks(1788), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(3433) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5074), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5082), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5085), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5088), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5090), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Diets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5093), new DateTime(2021, 6, 19, 22, 57, 1, 704, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Pilateis",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateStart",
                value: new DateTime(2021, 6, 19, 22, 57, 1, 708, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.CreateIndex(
                name: "IX_dateRequests_typeOfRequestId",
                table: "dateRequests",
                column: "typeOfRequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_dateRequests_packageRequests_typeOfRequestId",
                table: "dateRequests",
                column: "typeOfRequestId",
                principalTable: "packageRequests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
