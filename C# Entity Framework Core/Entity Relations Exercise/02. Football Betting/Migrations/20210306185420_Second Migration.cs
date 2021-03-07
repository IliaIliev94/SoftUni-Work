using Microsoft.EntityFrameworkCore.Migrations;

namespace _02._Football_Betting.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Colors_PrimaryKitColorId",
                table: "Teams");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Colors_PrimaryKitColorId",
                table: "Teams",
                column: "PrimaryKitColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Colors_PrimaryKitColorId",
                table: "Teams");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Colors_PrimaryKitColorId",
                table: "Teams",
                column: "PrimaryKitColorId",
                principalTable: "Colors",
                principalColumn: "ColorId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
