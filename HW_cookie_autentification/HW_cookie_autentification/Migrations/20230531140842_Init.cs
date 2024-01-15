using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_cookie_autentification.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Create = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modify = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Create = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modify = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: false),
                    Create = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modify = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ProductTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Create = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modify = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    Create = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modify = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Create", "Modify", "Name" },
                values: new object[] { 1, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2238), "Pavel" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Create", "Modify", "Name" },
                values: new object[] { 2, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2242), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2244), "Vitaliy" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Create", "Modify", "Name" },
                values: new object[] { 3, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2246), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2248), "Dmitry" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Create", "Modify", "Name" },
                values: new object[] { 1, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2188), "Oils" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Create", "Modify", "Name" },
                values: new object[] { 2, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2196), "Eats" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Create", "Modify", "Name" },
                values: new object[] { 3, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2198), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2200), "Water" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "Create", "Modify" },
                values: new object[] { 1, 1, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2313), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "Create", "Modify" },
                values: new object[] { 2, 2, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "ClientId", "Create", "Modify" },
                values: new object[] { 3, 2, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Create", "Modify", "Name", "ProductTypeId" },
                values: new object[] { 1, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2282), "Oil", 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Create", "Modify", "Name", "ProductTypeId" },
                values: new object[] { 2, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2289), "Butter", 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Create", "Modify", "Name", "ProductTypeId" },
                values: new object[] { 3, new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 5, 31, 17, 8, 42, 27, DateTimeKind.Local).AddTicks(2293), "Bread", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ProductTypes");
        }
    }
}
