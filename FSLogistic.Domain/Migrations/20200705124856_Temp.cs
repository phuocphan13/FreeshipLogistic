using Microsoft.EntityFrameworkCore.Migrations;

namespace FSLogistic.Domain.Migrations
{
    public partial class Temp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GUID",
                table: "Account",
                newName: "Guid");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "Autocomplete",
                type: "nvarchar(MAX)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Autocomplete",
                columns: new[] { "Id", "Data", "Type" },
                values: new object[] { 1, "132 Trường Chinh, Quận Tân Bình", 1 });

            migrationBuilder.InsertData(
                table: "Autocomplete",
                columns: new[] { "Id", "Data", "Type" },
                values: new object[] { 2, "0912 321 251", 2 });

            migrationBuilder.InsertData(
                table: "Autocomplete",
                columns: new[] { "Id", "Data", "Type" },
                values: new object[] { 3, "333 Trần Hưng Đạo, Quận 1", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autocomplete",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Autocomplete",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Autocomplete",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Account",
                newName: "GUID");

            migrationBuilder.AlterColumn<string>(
                name: "Data",
                table: "Autocomplete",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(MAX)",
                oldNullable: true);
        }
    }
}
