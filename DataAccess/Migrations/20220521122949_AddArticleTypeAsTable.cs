using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddArticleTypeAsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "TypeId",
                table: "Articles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Heading = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Name", "Heading" },
                values: new object[,]
                {
                    { "News", "съобщение" },
                    { "SchoolPlan", "училищен план" },
                    { "Course", "курс" },
                    { "AfterSeventhGrade", "новина относно приема след 7. клас" },
                    { "AfterFourthGrade", "новина относно приема след 4. клас" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_TypeId",
                table: "Articles",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Types_TypeId",
                table: "Articles",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Types_TypeId",
                table: "Articles");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropIndex(
                name: "IX_Articles_TypeId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Articles");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
