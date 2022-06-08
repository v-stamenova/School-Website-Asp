using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FixPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalFiles_Classes_ClassYear_ClassLetter",
                table: "AdditionalFiles");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalFiles_ClassYear_ClassLetter",
                table: "AdditionalFiles");

            migrationBuilder.DropColumn(
                name: "ClassLetter",
                table: "AdditionalFiles");

            migrationBuilder.DropColumn(
                name: "ClassYear",
                table: "AdditionalFiles");

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassYear = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ClassLetter = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Classes_ClassYear_ClassLetter",
                        columns: x => new { x.ClassYear, x.ClassLetter },
                        principalTable: "Classes",
                        principalColumns: new[] { "Year", "Letter" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ClassYear_ClassLetter",
                table: "Photos",
                columns: new[] { "ClassYear", "ClassLetter" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.AddColumn<string>(
                name: "ClassLetter",
                table: "AdditionalFiles",
                type: "nvarchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClassYear",
                table: "AdditionalFiles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalFiles_ClassYear_ClassLetter",
                table: "AdditionalFiles",
                columns: new[] { "ClassYear", "ClassLetter" });

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalFiles_Classes_ClassYear_ClassLetter",
                table: "AdditionalFiles",
                columns: new[] { "ClassYear", "ClassLetter" },
                principalTable: "Classes",
                principalColumns: new[] { "Year", "Letter" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
