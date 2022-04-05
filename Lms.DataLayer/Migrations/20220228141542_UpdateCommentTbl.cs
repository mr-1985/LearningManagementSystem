using Microsoft.EntityFrameworkCore.Migrations;

namespace Lms.DataLayer.Migrations
{
    public partial class UpdateCommentTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "PageComments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PageComments");

            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "PageComments");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PageComments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PageComments_UserId",
                table: "PageComments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PageComments_Users_UserId",
                table: "PageComments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PageComments_Users_UserId",
                table: "PageComments");

            migrationBuilder.DropIndex(
                name: "IX_PageComments_UserId",
                table: "PageComments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PageComments");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PageComments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PageComments",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "PageComments",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }
    }
}
