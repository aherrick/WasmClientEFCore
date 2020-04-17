using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WasmClientEFCore.Db.Migrations
{
    public partial class AddCustomerName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Orders",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 4, 17, 11, 59, 23, 785, DateTimeKind.Utc).AddTicks(7545));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2020, 4, 17, 11, 47, 27, 750, DateTimeKind.Utc).AddTicks(6459));
        }
    }
}
