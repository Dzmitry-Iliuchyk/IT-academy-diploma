using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW_cookie_autentification.Migrations.UserDb
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Description", "Email", "Name", "Password", "Phone", "Role" },
                values: new object[] { 1, null, "Dmitry123@mail.ru", "Dmitry", "123", null, "1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Description", "Email", "Name", "Password", "Phone", "Role" },
                values: new object[] { 2, null, "1@mail.ru", "DD", "123", null, "customer" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Description", "Email", "Name", "Password", "Phone", "Role" },
                values: new object[] { 3, null, "2@mail.ru", "Mit", "123", null, "admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Description", "Email", "Name", "Password", "Phone", "Role" },
                values: new object[] { 4, null, "3@mail.ru", "adsa", "123", null, "supervisor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
