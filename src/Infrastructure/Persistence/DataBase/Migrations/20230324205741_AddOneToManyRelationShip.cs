using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pandape.Infrastructure.Migrations
{
    public partial class AddOneToManyRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2023, 3, 24, 20, 57, 41, 304, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2023, 3, 24, 20, 57, 41, 307, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.CreateIndex(
                name: "IX_CandidateExperiences_CandidateId",
                table: "CandidateExperiences",
                column: "CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidateId",
                table: "CandidateExperiences",
                column: "CandidateId",
                principalTable: "Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CandidateExperiences_Candidates_CandidateId",
                table: "CandidateExperiences");

            migrationBuilder.DropIndex(
                name: "IX_CandidateExperiences_CandidateId",
                table: "CandidateExperiences");

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 1,
                column: "InsertDate",
                value: new DateTime(2023, 3, 24, 20, 7, 25, 350, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Candidates",
                keyColumn: "Id",
                keyValue: 2,
                column: "InsertDate",
                value: new DateTime(2023, 3, 24, 20, 7, 25, 352, DateTimeKind.Local).AddTicks(9694));
        }
    }
}
