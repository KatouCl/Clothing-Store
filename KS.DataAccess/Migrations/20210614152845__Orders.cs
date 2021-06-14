using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.DataAccess.Migrations
{
    public partial class _Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Orders_OrderId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_OrderId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "ReservedQuantity",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderRef",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "StripeReference",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "CustomerId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeliveryId",
                table: "Orders",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryType = table.Column<byte>(type: "tinyint", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: true),
                    OrderId = table.Column<long>(type: "bigint", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dfa8a207-5311-4825-9a95-38f8588154c8", "AQAAAAEAACcQAAAAEKhlPgBIfz1oaj4vQotxEBxgSSa8kQr0Td5Yk4+Lm/LgSNG9ogT88tKPoYp90b3saA==" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 826, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 827, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 828, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 828, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 828, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 828, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 14, 18, 28, 43, 828, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryId",
                table: "Orders",
                column: "DeliveryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Deliveries_DeliveryId",
                table: "Orders",
                column: "DeliveryId",
                principalTable: "Deliveries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Deliveries_DeliveryId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DeliveryId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Orders");

            migrationBuilder.AddColumn<long>(
                name: "OrderId",
                table: "Stocks",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReservedQuantity",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderRef",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StripeReference",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1405e4ba-dbb1-473f-95f4-30afff8348f4", "AQAAAAEAACcQAAAAEFPm8iU4twlvqVZWMmeNJwne94dKR3k1dfkpWoZ3BXI5/mEChBKDOlht7y83A19orw==" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 698, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 11, 16, 33, 38, 700, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_OrderId",
                table: "Stocks",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Orders_OrderId",
                table: "Stocks",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
