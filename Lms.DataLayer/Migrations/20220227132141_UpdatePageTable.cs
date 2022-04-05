using Microsoft.EntityFrameworkCore.Migrations;

namespace Lms.DataLayer.Migrations
{
    public partial class UpdatePageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Pages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pages_AuthorId",
                table: "Pages",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pages_Users_AuthorId",
                table: "Pages",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pages_Users_AuthorId",
                table: "Pages");

            migrationBuilder.DropIndex(
                name: "IX_Pages_AuthorId",
                table: "Pages");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Pages");
        }
    }
}
