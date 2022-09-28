using Microsoft.EntityFrameworkCore.Migrations;

namespace Elementos_Quimicos.Migrations
{
    public partial class RemoveField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "Families");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "Families",
                type: "TEXT",
                nullable: true);
        }
    }
}
