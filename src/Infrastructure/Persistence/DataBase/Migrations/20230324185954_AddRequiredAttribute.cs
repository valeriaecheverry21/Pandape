using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandape.Infrastructure.Migrations
{
    public partial class AddRequiredAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Candidates",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Candidates",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                unicode: false,
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "CandidateExperiences",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CandidateExperiences",
                type: "varchar(4000)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(4000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "CandidateExperiences",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2023, 3, 24, 18, 59, 53, 947, DateTimeKind.Local).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "IdCandidate",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2023, 3, 24, 18, 59, 53, 950, DateTimeKind.Local).AddTicks(157));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Candidates",
                type: "varchar(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Candidates",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "CandidateExperiences",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CandidateExperiences",
                type: "varchar(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(4000)");

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "CandidateExperiences",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2023, 3, 24, 18, 50, 49, 854, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "IdCandidate",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2023, 3, 24, 18, 50, 49, 856, DateTimeKind.Local).AddTicks(6405));
        }
    }
}
