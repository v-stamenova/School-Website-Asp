using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddTargetAndNormTypeToArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NormType",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Target",
                table: "Articles",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NormType",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Target",
                table: "Articles");
        }
    }
}
