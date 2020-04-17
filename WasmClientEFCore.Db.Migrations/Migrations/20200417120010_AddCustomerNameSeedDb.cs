using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WasmClientEFCore.Db.Migrations
{
    public partial class AddCustomerNameSeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CustomerName", "OrderDate" },
                values: new object[] { "Herrick", new DateTime(2020, 4, 17, 12, 0, 9, 632, DateTimeKind.Utc).AddTicks(6061) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CustomerName", "OrderDate" },
                values: new object[] { null, new DateTime(2020, 4, 17, 11, 59, 23, 785, DateTimeKind.Utc).AddTicks(7545) });
        }
    }
}
