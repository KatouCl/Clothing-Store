using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.DataAccess.Migrations
{
    public partial class _UserAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "1405e4ba-dbb1-473f-95f4-30afff8348f4", true, "admin@gmail.com", "admin", "AQAAAAEAACcQAAAAEFPm8iU4twlvqVZWMmeNJwne94dKR3k1dfkpWoZ3BXI5/mEChBKDOlht7y83A19orw==", null, "", "admin" });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "43d4c7aa-c5a7-45e7-b2c3-a56a1be04c45", false, null, null, null, "1234567890", null, "Admin" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 587, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 590, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 591, DateTimeKind.Local).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 10, 0, 23, 28, 591, DateTimeKind.Local).AddTicks(4321));
        }
    }
}
