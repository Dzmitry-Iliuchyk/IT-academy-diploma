using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_cookie_autentification.Migrations
{
    public partial class AddfieldNameinOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5214), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5221), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5225), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify", "Name" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5306), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5309), "Order 1" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify", "Name" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5317), "Order 2" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify", "Name" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5322), "Order 3" });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5043), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5169), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5264), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5267) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5275), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5279), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5281) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2242), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2246), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2313), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2198), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2293) });
        }
    }
}
