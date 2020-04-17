using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WasmClientEFCore.Db.Migrations
{
    public partial class AddWeightSum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 100);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 4, 17, 12, 8, 1, 46, DateTimeKind.Utc).AddTicks(2870));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 4, 17, 12, 6, 39, 512, DateTimeKind.Utc).AddTicks(7972));
        }
    }
}
