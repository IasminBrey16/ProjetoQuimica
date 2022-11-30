using Microsoft.EntityFrameworkCore.Migrations;

namespace Elementos_Quimicos.Migrations
{
    public partial class RemoveFieldInElement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "Elements");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Period",
                table: "Elements",
                type: "TEXT",
                nullable: true);
        }
    }
}
