using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankUserApi.Migrations
{
    public partial class start3900000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatDate",
                table: "Cards");

            migrationBuilder.RenameColumn(
                name: "FinishedDate",
                table: "Cards",
                newName: "UseTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UseTime",
                table: "Cards",
                newName: "FinishedDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatDate",
                table: "Cards",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
