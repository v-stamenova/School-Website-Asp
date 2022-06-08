using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Year = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Letter = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    HomeroomTeacherId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => new { x.Year, x.Letter });
                    table.ForeignKey(
                        name: "FK_Classes_Teachers_HomeroomTeacherId",
                        column: x => x.HomeroomTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Username",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleNameInitial = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    FamilyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Letter = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classes_Year_Letter",
                        columns: x => new { x.Year, x.Letter },
                        principalTable: "Classes",
                        principalColumns: new[] { "Year", "Letter" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdditionalFiles_ClassYear_ClassLetter",
                table: "AdditionalFiles",
                columns: new[] { "ClassYear", "ClassLetter" });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_HomeroomTeacherId",
                table: "Classes",
                column: "HomeroomTeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Year_Letter",
                table: "Students",
                columns: new[] { "Year", "Letter" });

            migrationBuilder.AddForeignKey(
                name: "FK_AdditionalFiles_Classes_ClassYear_ClassLetter",
                table: "AdditionalFiles",
                columns: new[] { "ClassYear", "ClassLetter" },
                principalTable: "Classes",
                principalColumns: new[] { "Year", "Letter" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdditionalFiles_Classes_ClassYear_ClassLetter",
                table: "AdditionalFiles");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropIndex(
                name: "IX_AdditionalFiles_ClassYear_ClassLetter",
                table: "AdditionalFiles");

            migrationBuilder.DropColumn(
                name: "ClassLetter",
                table: "AdditionalFiles");

            migrationBuilder.DropColumn(
                name: "ClassYear",
                table: "AdditionalFiles");
        }
    }
}
