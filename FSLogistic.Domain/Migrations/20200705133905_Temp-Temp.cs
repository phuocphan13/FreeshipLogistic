using Microsoft.EntityFrameworkCore.Migrations;

namespace FSLogistic.Domain.Migrations
{
    public partial class TempTemp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Account");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
