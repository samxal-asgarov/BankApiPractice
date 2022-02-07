using Microsoft.EntityFrameworkCore.Migrations;

namespace BankUserApi.Migrations
{
    public partial class start39 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Banks_BankId",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_BankId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "BankId",
                table: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Banks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Banks_CardId",
                table: "Banks",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Banks_Cards_CardId",
                table: "Banks",
                column: "CardId",
                principalTable: "Cards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Banks_Cards_CardId",
                table: "Banks");

            migrationBuilder.DropIndex(
                name: "IX_Banks_CardId",
                table: "Banks");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Banks");

            migrationBuilder.AddColumn<int>(
                name: "BankId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cards_BankId",
                table: "Cards",
                column: "BankId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Banks_BankId",
                table: "Cards",
                column: "BankId",
                principalTable: "Banks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
