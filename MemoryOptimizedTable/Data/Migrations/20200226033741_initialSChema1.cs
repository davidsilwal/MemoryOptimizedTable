using Microsoft.EntityFrameworkCore.Migrations;

namespace MemoryOptimizedTable.Data.Migrations
{
    public partial class initialSChema1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "test" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "test1" });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "test2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
