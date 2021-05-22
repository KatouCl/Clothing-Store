using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.DataAccess.Migrations
{
    public partial class _Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GenderTypeId",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "UnitType",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitType",
                table: "Products");

            migrationBuilder.AddColumn<byte>(
                name: "GenderTypeId",
                table: "Products",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
