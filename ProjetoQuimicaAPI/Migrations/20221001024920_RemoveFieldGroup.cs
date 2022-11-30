using Microsoft.EntityFrameworkCore.Migrations;

namespace Elementos_Quimicos.Migrations
{
    public partial class RemoveFieldGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "Elements");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Group",
                table: "Elements",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
