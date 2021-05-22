using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.DataAccess.Migrations
{
    public partial class _changeProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Warehouses");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "Warehouses");

            migrationBuilder.AddColumn<bool>(
                name: "HasOptions",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasOptions",
                table: "Products");

            migrationBuilder.AddColumn<long>(
                name: "AddressId",
                table: "Warehouses",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "VendorId",
                table: "Warehouses",
                type: "bigint",
                nullable: true);
        }
    }
}
