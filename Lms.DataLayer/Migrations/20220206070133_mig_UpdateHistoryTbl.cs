using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lms.DataLayer.Migrations
{
    public partial class mig_UpdateHistoryTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionHistories_UserStatus_ExamStatusId",
                table: "QuestionHistories");

            migrationBuilder.DropIndex(
                name: "IX_QuestionHistories_ExamStatusId",
                table: "QuestionHistories");

            migrationBuilder.DropColumn(
                name: "ExamStatusId",
                table: "QuestionHistories");

            migrationBuilder.DropColumn(
                name: "QuestionOrder",
                table: "QuestionHistories");

            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "QuestionHistories");

            migrationBuilder.DropColumn(
                name: "UserExamRemainTime",
                table: "QuestionHistories");

            migrationBuilder.AddColumn<int>(
                name: "UserStatusExamStatusId",
                table: "QuestionHistories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionHistories_UserStatusExamStatusId",
                table: "QuestionHistories",
                column: "UserStatusExamStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionHistories_UserStatus_UserStatusExamStatusId",
                table: "QuestionHistories",
                column: "UserStatusExamStatusId",
                principalTable: "UserStatus",
                principalColumn: "ExamStatusId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionHistories_UserStatus_UserStatusExamStatusId",
                table: "QuestionHistories");

            migrationBuilder.DropIndex(
                name: "IX_QuestionHistories_UserStatusExamStatusId",
                table: "QuestionHistories");

            migrationBuilder.DropColumn(
                name: "UserStatusExamStatusId",
                table: "QuestionHistories");

            migrationBuilder.AddColumn<int>(
                name: "ExamStatusId",
                table: "QuestionHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestionOrder",
                table: "QuestionHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestionType",
                table: "QuestionHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "UserExamRemainTime",
                table: "QuestionHistories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_QuestionHistories_ExamStatusId",
                table: "QuestionHistories",
                column: "ExamStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionHistories_UserStatus_ExamStatusId",
                table: "QuestionHistories",
                column: "ExamStatusId",
                principalTable: "UserStatus",
                principalColumn: "ExamStatusId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
