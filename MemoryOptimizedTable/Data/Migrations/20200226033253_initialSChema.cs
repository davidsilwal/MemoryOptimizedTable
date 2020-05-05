using Microsoft.EntityFrameworkCore.Migrations;

namespace MemoryOptimizedTable.Data.Migrations
{
    public partial class initialSChema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.AlterDatabase()
                .Annotation("SqlServer:MemoryOptimized", true);

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id)
                        .Annotation("SqlServer:Clustered", false);
                })
                .Annotation("SqlServer:MemoryOptimized", true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests")
                .Annotation("SqlServer:MemoryOptimized", true);

            migrationBuilder.AlterDatabase()
                .OldAnnotation("SqlServer:MemoryOptimized", true);
        }
    }
}
