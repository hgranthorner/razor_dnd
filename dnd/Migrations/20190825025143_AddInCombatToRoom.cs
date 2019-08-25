using Microsoft.EntityFrameworkCore.Migrations;

namespace dnd.Migrations
{
    public partial class AddInCombatToRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "InCombat",
                table: "Rooms",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InCombat",
                table: "Rooms");
        }
    }
}
