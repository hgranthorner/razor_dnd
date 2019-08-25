using Microsoft.EntityFrameworkCore.Migrations;

namespace dnd.Migrations
{
    public partial class AddedInitiativesToCharacters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Initiative",
                table: "Characters",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Initiative",
                table: "Characters");
        }
    }
}
