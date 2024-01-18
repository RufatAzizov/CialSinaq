using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cial.Migrations
{
    public partial class CreatedClientsTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TeamData",
                table: "TeamData");

            migrationBuilder.RenameTable(
                name: "TeamData",
                newName: "OurTeam");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OurTeam",
                table: "OurTeam",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OurTeam",
                table: "OurTeam");

            migrationBuilder.RenameTable(
                name: "OurTeam",
                newName: "TeamData");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeamData",
                table: "TeamData",
                column: "Id");
        }
    }
}
