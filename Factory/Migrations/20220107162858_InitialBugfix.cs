using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class InitialBugfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Engineerid",
                table: "Engineers",
                newName: "EngineerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EngineerId",
                table: "Engineers",
                newName: "Engineerid");
        }
    }
}
