using Microsoft.EntityFrameworkCore.Migrations;

namespace Lms.DataLayer.Migrations
{
    public partial class mig_UpdateSomeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnswerFile",
                table: "MultipleQuestions",
                newName: "Alternate4File");

            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "MultipleQuestions",
                newName: "Alternate4");

            migrationBuilder.AlterColumn<string>(
                name: "CorrectAnswer",
                table: "MultipleQuestions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Exams",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Exams");

            migrationBuilder.RenameColumn(
                name: "Alternate4File",
                table: "MultipleQuestions",
                newName: "AnswerFile");

            migrationBuilder.RenameColumn(
                name: "Alternate4",
                table: "MultipleQuestions",
                newName: "Answer");

            migrationBuilder.AlterColumn<int>(
                name: "CorrectAnswer",
                table: "MultipleQuestions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
