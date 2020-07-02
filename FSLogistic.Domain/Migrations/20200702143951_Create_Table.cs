using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSLogistic.Domain.Migrations
{
    public partial class Create_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    GUID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Autocomplete",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(nullable: false),
                    Data = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autocomplete", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Q1 = table.Column<decimal>(nullable: true),
                    Q2 = table.Column<decimal>(nullable: true),
                    Q3 = table.Column<decimal>(nullable: true),
                    Q4 = table.Column<decimal>(nullable: true),
                    Q5 = table.Column<decimal>(nullable: true),
                    Q6 = table.Column<decimal>(nullable: true),
                    Q7 = table.Column<decimal>(nullable: true),
                    Q8 = table.Column<decimal>(nullable: true),
                    Q9 = table.Column<decimal>(nullable: true),
                    Q10 = table.Column<decimal>(nullable: true),
                    Q11 = table.Column<decimal>(nullable: true),
                    Q12 = table.Column<decimal>(nullable: true),
                    QTD = table.Column<decimal>(nullable: true),
                    QGV = table.Column<decimal>(nullable: true),
                    QBTH = table.Column<decimal>(nullable: true),
                    QTB = table.Column<decimal>(nullable: true),
                    QTP = table.Column<decimal>(nullable: true),
                    QBTN = table.Column<decimal>(nullable: true),
                    QPN = table.Column<decimal>(nullable: true),
                    Qcc = table.Column<decimal>(nullable: true),
                    QHM = table.Column<decimal>(nullable: true),
                    QBC = table.Column<decimal>(nullable: true),
                    QNB = table.Column<decimal>(nullable: true),
                    QCG = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    Title = table.Column<string>(maxLength: 256, nullable: true),
                    Note = table.Column<string>(maxLength: 256, nullable: true),
                    Total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    ReceiverName = table.Column<string>(maxLength: 256, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    District = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    CustomerNote = table.Column<string>(nullable: true),
                    Total = table.Column<decimal>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false),
                    AdvanceMoney = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StaffNote = table.Column<string>(nullable: true),
                    DoneDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    AccountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bill_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bill_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_AccountId",
                table: "Bill",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CustomerId",
                table: "Bill",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autocomplete");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Summary");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
