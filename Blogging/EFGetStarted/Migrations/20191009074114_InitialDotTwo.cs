using Microsoft.EntityFrameworkCore.Migrations;

namespace EFGetStarted.Migrations
{
    public partial class InitialDotTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "Blogs",
                newName: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "Blogs",
                newName: "BlogID");
        }
    }
}
