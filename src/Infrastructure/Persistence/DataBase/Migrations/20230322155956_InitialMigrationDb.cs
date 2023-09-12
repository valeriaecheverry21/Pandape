using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandape.Infrastructure.Migrations
{
    public partial class InitialMigrationDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CandidateExperiences",
                columns: table => new
                {
                    IdCandidateExperience = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCandidate = table.Column<int>(nullable: false),
                    Company = table.Column<string>(maxLength: 100, nullable: true),
                    Job = table.Column<string>(maxLength: 100, nullable: true),
                    Description = table.Column<string>(maxLength: 4000, nullable: true),
                    Salary = table.Column<decimal>(nullable: false),
                    BeginDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateExperiences", x => x.IdCandidateExperience);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    IdCandidate = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    SurName = table.Column<string>(maxLength: 150, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 250, nullable: true),
                    InsertDate = table.Column<DateTime>(nullable: false),
                    ModifyDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.IdCandidate);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateExperiences");

            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
