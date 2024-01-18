using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cial.Migrations
{
    public partial class CreatedSliderTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "SliderData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SliderData");

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
    }
}
