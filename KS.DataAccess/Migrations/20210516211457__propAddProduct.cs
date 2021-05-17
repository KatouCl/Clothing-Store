using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.DataAccess.Migrations
{
    public partial class _propAddProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Images_CoverImageId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CoverImageId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CoverImageId",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "CoverImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverImageUrl",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "CoverImageId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CoverImageId",
                table: "Products",
                column: "CoverImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Images_CoverImageId",
                table: "Products",
                column: "CoverImageId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
