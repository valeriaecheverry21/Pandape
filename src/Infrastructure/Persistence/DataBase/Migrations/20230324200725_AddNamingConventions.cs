using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandape.Infrastructure.Migrations
{
    public partial class AddNamingConventions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidateIdCandidate",
                table: "CandidateExperiences");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidates",
                table: "Candidates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateExperiences",
                table: "CandidateExperiences");

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
                name: "IdCandidate",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "IdCandidateExperience",
                table: "CandidateExperiences");

            migrationBuilder.DropColumn(
                name: "CandidateIdCandidate",
                table: "CandidateExperiences");

            migrationBuilder.DropColumn(
                name: "IdCandidate",
                table: "CandidateExperiences");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Candidates",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CandidateExperiences",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "CandidateExperiences",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Candidates_Email",
                table: "Candidates",
                column: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidates",
                table: "Candidates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateExperiences",
                table: "CandidateExperiences",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BirthDate", "Email", "InsertDate", "ModifyDate", "Name", "SurName" },
                values: new object[] { 1, new DateTime(1982, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "alejandro@gmail.com", new DateTime(2023, 3, 24, 20, 7, 25, 350, DateTimeKind.Local).AddTicks(3000), null, "Alejandro", "Montu" });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "Id", "BirthDate", "Email", "InsertDate", "ModifyDate", "Name", "SurName" },
                values: new object[] { 2, new DateTime(1974, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "jorge@gmail.com", new DateTime(2023, 3, 24, 20, 7, 25, 352, DateTimeKind.Local).AddTicks(9694), null, "Jorge", "Gallardo" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Candidates_Email",
                table: "Candidates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidates",
                table: "Candidates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CandidateExperiences",
                table: "CandidateExperiences");

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CandidateExperiences");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "CandidateExperiences");

            migrationBuilder.AddColumn<int>(
                name: "IdCandidate",
                table: "Candidates",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "IdCandidateExperience",
                table: "CandidateExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CandidateIdCandidate",
                table: "CandidateExperiences",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCandidate",
                table: "CandidateExperiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidates",
                table: "Candidates",
                column: "IdCandidate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CandidateExperiences",
                table: "CandidateExperiences",
                column: "IdCandidateExperience");

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "IdCandidate", "BirthDate", "Email", "InsertDate", "ModifyDate", "Name", "SurName" },
                values: new object[] { 1, new DateTime(1982, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "alejandro@gmail.com", new DateTime(2023, 3, 24, 18, 59, 53, 947, DateTimeKind.Local).AddTicks(3176), null, "Alejandro", "Montu" });

            migrationBuilder.InsertData(
                table: "Candidates",
                columns: new[] { "IdCandidate", "BirthDate", "Email", "InsertDate", "ModifyDate", "Name", "SurName" },
                values: new object[] { 2, new DateTime(1974, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "jorge@gmail.com", new DateTime(2023, 3, 24, 18, 59, 53, 950, DateTimeKind.Local).AddTicks(157), null, "Jorge", "Gallardo" });

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
    }
}
