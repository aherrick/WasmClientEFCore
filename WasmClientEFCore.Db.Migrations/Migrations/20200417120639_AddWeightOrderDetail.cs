using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WasmClientEFCore.Db.Migrations
{
    public partial class AddWeightOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 4, 17, 12, 6, 39, 512, DateTimeKind.Utc).AddTicks(7972));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "OrderDetails");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 4, 17, 12, 0, 9, 632, DateTimeKind.Utc).AddTicks(6061));
        }
    }
}
