using Microsoft.EntityFrameworkCore.Migrations;

namespace Entekhab_Vahed_Wpf.Migrations
{
    public partial class SeedInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admin",
                keyColumn: "id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "id", "Password", "Username" },
                values: new object[] { 1, "1", "1" });
        }
    }
}
