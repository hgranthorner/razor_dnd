using Microsoft.EntityFrameworkCore.Migrations;

namespace dnd.Migrations
{
    public partial class AddDexToCharacterModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dex",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name", "Password" },
                values: new object[,]
                {
                    { 3, "Grant", "gillovespoo" },
                    { 4, "Matt", "gillovespoo" },
                    { 5, "Carolyn", "gillovespoo" },
                    { 6, "Greg", "gillovespoo" },
                    { 7, "Quinn", "gillovespoo" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Dex", "Name", "Race", "RoomId", "UserId" },
                values: new object[,]
                {
                    { 2, 0, "Tormatyr", "Aasimar", 1, 3 },
                    { 3, 0, "Matt's Character", "Human", 1, 4 },
                    { 4, 0, "Carolyn's Character", "Human", 1, 5 },
                    { 6, 0, "Greg's Character", "Human", 1, 6 },
                    { 5, 0, "Quinn's Character", "Human", 1, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "Dex",
                table: "Characters");
        }
    }
}
