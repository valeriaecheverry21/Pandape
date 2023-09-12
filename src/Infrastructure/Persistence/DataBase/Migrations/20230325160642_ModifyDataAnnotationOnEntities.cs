using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandape.Infrastructure.Migrations
{
    public partial class ModifyDataAnnotationOnEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Candidates_Email",
                table: "Candidates");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_Id",
                table: "Candidates");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                type: "varchar(250)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(250)");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Candidates_Email",
                table: "Candidates",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_Id",
                table: "Candidates",
                column: "Id",
                unique: true);
        }
    }
}
