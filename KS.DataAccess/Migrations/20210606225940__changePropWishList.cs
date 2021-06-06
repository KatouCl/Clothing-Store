using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.DataAccess.Migrations
{
    public partial class _changePropWishList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "WishLists");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "WishLists",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "WishLists");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "WishLists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
