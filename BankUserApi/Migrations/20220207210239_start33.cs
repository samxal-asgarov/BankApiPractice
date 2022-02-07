using Microsoft.EntityFrameworkCore.Migrations;

namespace BankUserApi.Migrations
{
    public partial class start33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankId",
                table: "Banks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Banks_BankId",
                table: "Banks",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_Banks_BankId",
                table: "Banks",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banks_Banks_BankId",
                table: "Banks");

            migrationBuilder.DropIndex(
                name: "IX_Banks_BankId",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "Banks");
        }
    }
}
