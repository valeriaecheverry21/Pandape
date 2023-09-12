using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandape.Infrastructure.Migrations
{
    public partial class ModifyTypesToVarchar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Candidates_Email",
                table: "Candidates");

            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Candidates",
                type: "varchar(150)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Candidates",
                type: "varchar(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "CandidateExperiences",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CandidateExperiences",
                type: "varchar(4000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "CandidateExperiences",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SurName",
                table: "Candidates",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Candidates",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Job",
                table: "CandidateExperiences",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CandidateExperiences",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(4000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Company",
                table: "CandidateExperiences",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Candidates_Email",
                table: "Candidates",
                column: "Email");

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "IdCandidate",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2023, 3, 22, 23, 12, 42, 184, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "IdCandidate",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2023, 3, 22, 23, 12, 42, 187, DateTimeKind.Local).AddTicks(6595));
        }
    }
}
