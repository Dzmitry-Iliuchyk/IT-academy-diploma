using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_cookie_autentification.Migrations
{
    public partial class Food : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3987), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3994) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4004), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4009) });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4015), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4154), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4176), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4188), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3823), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify", "Name" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3904), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3909), "Food" });

            migrationBuilder.UpdateData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3916), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4071), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4090), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Create", "Modify" },
                values: new object[] { new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4101), new DateTime(2023, 6, 28, 15, 29, 49, 179, DateTimeKind.Local).AddTicks(4106) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "Create", "Modify", "Name" },
                values: new object[] { new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5583), new DateTime(2023, 6, 3, 11, 51, 12, 753, DateTimeKind.Local).AddTicks(5584), "Eats" });

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
    }
}
