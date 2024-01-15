using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_cookie_autentification.Migrations
{
    public partial class Relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5621), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5624) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5629), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5633), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5635) });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Create", "Modify", "OrderId", "ProductId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Create", "Modify", "OrderId", "ProductId" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "Create", "Modify", "OrderId", "ProductId" },
                values: new object[] { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5698), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5701) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5775), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5780), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5537), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5583), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5584) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5661), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5663) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5669), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5671) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5674), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5676) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 3);

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
    }
}
