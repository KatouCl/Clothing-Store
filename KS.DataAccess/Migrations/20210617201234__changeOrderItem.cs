using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.DataAccess.Migrations
{
    public partial class _changeOrderItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ccb68588-f85e-43d4-b8a3-f031bff20613", "AQAAAAEAACcQAAAAEPZv2dle7aSM6fLkNL2w/C9PRMi43tBIqk0A71ho8OsKhp2HVMMGpMzbuJs9pvXsYw==" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 173, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 176, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 177, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 17, 23, 12, 33, 177, DateTimeKind.Local).AddTicks(483));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "OrderItems");

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
        }
    }
}
