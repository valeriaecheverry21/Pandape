using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandape.Infrastructure.Migrations
{
    public partial class ModifyInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "CandidateExperiences",
                type: "decimal(8,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "CandidateIdCandidate",
                table: "CandidateExperiences",
                nullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Candidates_Email",
                table: "Candidates",
                column: "Email");

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "IdCandidate", "BirthDate", "Email", "InsertDate", "ModifyDate", "Name", "SurName" },
                values: new object[] { 1, new DateTime(1982, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "alejandro@gmail.com", new DateTime(2023, 3, 22, 23, 12, 42, 184, DateTimeKind.Local).AddTicks(9412), null, "Alejandro", "Montu" });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "IdCandidate", "BirthDate", "Email", "InsertDate", "ModifyDate", "Name", "SurName" },
                values: new object[] { 2, new DateTime(1974, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "jorge@gmail.com", new DateTime(2023, 3, 22, 23, 12, 42, 187, DateTimeKind.Local).AddTicks(6595), null, "Jorge", "Gallardo" });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateExperiences_CandidateIdCandidate",
                table: "CandidateExperiences",
                column: "CandidateIdCandidate");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidateIdCandidate",
                table: "CandidateExperiences",
                column: "CandidateIdCandidate",
                principalTable: "Candidates",
                principalColumn: "IdCandidate",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidateIdCandidate",
                table: "CandidateExperiences");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Candidates_Email",
                table: "Candidates");

            migrationBuilder.DropIndex(
                name: "IX_CandidateExperiences_CandidateIdCandidate",
                table: "CandidateExperiences");

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "IdCandidate",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "IdCandidate",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CandidateIdCandidate",
                table: "CandidateExperiences");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "CandidateExperiences",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");
        }
    }
}
