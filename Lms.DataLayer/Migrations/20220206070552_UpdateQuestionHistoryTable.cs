using Microsoft.EntityFrameworkCore.Migrations;

namespace Lms.DataLayer.Migrations
{
    public partial class UpdateQuestionHistoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
