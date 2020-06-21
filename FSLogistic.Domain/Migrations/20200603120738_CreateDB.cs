using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSLogistic.Domain.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeStaff = table.Column<string>(nullable: false),
                    AuthenId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
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
                    Enum = table.Column<int>(nullable: false),
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
                    CodeCustomer = table.Column<string>(nullable: false),
                    NameCustomer = table.Column<string>(nullable: false),
                    Q1 = table.Column<string>(nullable: false),
                    Q2 = table.Column<string>(nullable: false),
                    Q3 = table.Column<string>(nullable: false),
                    Q4 = table.Column<string>(nullable: false),
                    Q5 = table.Column<string>(nullable: false),
                    Q6 = table.Column<string>(nullable: false),
                    Q7 = table.Column<string>(nullable: false),
                    Q8 = table.Column<string>(nullable: false),
                    Q9 = table.Column<string>(nullable: false),
                    Q10 = table.Column<string>(nullable: false),
                    Q11 = table.Column<string>(nullable: false),
                    Q12 = table.Column<string>(nullable: false),
                    QTD = table.Column<string>(nullable: false),
                    QGV = table.Column<string>(nullable: false),
                    QBTH = table.Column<string>(nullable: false),
                    QTB = table.Column<string>(nullable: false),
                    QTP = table.Column<string>(nullable: false),
                    QBTN = table.Column<string>(nullable: false),
                    QPN = table.Column<string>(nullable: false),
                    Qcc = table.Column<string>(nullable: false),
                    QHM = table.Column<string>(nullable: false),
                    QBC = table.Column<string>(nullable: false),
                    QNB = table.Column<string>(nullable: false),
                    QCG = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
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
                    OtherPay = table.Column<string>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdateBy = table.Column<int>(nullable: false)
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
                    CustomerId = table.Column<int>(nullable: true),
                    NameReceiver = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    District = table.Column<int>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true),
                    CustomerNote = table.Column<string>(nullable: true),
                    AccountId = table.Column<int>(nullable: true),
                    TotalPrice = table.Column<string>(nullable: true),
                    ShippingFee = table.Column<string>(nullable: true),
                    AdvanceMoney = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    StaffNote = table.Column<string>(nullable: true),
                    DoneDate = table.Column<DateTime>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bill_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bill_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
