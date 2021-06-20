using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KS.DataAccess.Migrations
{
    public partial class _CreateContactFeedBack : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Context = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "640e5444-d7cd-4dbc-b3bb-7e0668edd4a5", "AQAAAAEAACcQAAAAEOIt3qvi83AwLqxismBf4rInNCMREXhA6mOHao/5Jy6ek3CpvMV+R7LPYgprfjQyDQ==" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 854, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7378));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7389));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "TaxClasses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 855, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 856, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Warehouses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreationDate",
                value: new DateTime(2021, 6, 20, 14, 16, 10, 856, DateTimeKind.Local).AddTicks(874));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "FeedBacks");

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
    }
}
