using Microsoft.EntityFrameworkCore.Migrations;

namespace BankUserApi.Migrations
{
    public partial class start3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banks_Banks_BankId",
                table: "Banks");

            migrationBuilder.RenameColumn(
                name: "BankId",
                table: "Banks",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Banks_BankId",
                table: "Banks",
                newName: "IX_Banks_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_Users_UserId",
                table: "Banks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banks_Users_UserId",
                table: "Banks");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Banks",
                newName: "BankId");

            migrationBuilder.RenameIndex(
                name: "IX_Banks_UserId",
                table: "Banks",
                newName: "IX_Banks_BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_Banks_BankId",
                table: "Banks",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
