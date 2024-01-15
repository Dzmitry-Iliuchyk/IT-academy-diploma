using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_cookie_autentification.Migrations
{
    public partial class Addpropertyname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1358), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1364), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1366) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1369), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1442), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1451), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1452) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1455), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1165), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1214) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1227), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1229) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1231), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1406), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1414), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1418), new DateTime(2023, 6, 3, 10, 40, 55, 976, DateTimeKind.Local).AddTicks(1420) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5306), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5309) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5315), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5320), new DateTime(2023, 6, 2, 22, 42, 27, 561, DateTimeKind.Local).AddTicks(5322) });

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
    }
}
