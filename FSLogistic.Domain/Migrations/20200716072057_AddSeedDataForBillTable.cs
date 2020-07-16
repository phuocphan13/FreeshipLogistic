using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSLogistic.Domain.Migrations
{
    public partial class AddSeedDataForBillTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Name", "Q1", "Q10", "Q11", "Q12", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "Q8", "Q9", "QBC", "QBTH", "QBTN", "QCG", "QGV", "QHM", "QNB", "QPN", "QTB", "QTD", "QTP", "Qcc", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "TranDan", 1, new DateTime(2020, 7, 16, 14, 20, 56, 884, DateTimeKind.Local).AddTicks(1447), "Trần Dần", 30000m, 30000m, 30000m, 30000m, 50000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, null, null });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedDate", "Name", "Q1", "Q10", "Q11", "Q12", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "Q8", "Q9", "QBC", "QBTH", "QBTN", "QCG", "QGV", "QHM", "QNB", "QPN", "QTB", "QTD", "QTP", "Qcc", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2, "Truong3Gio", 1, new DateTime(2020, 7, 16, 14, 20, 56, 886, DateTimeKind.Local).AddTicks(7657), "Trương Tam Phong", 30000m, 30000m, 30000m, 30000m, 50000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, 30000m, null, null });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "Id", "AccountId", "Address", "AdvanceMoney", "CreatedBy", "CreatedDate", "CustomerId", "CustomerNote", "District", "DoneDate", "Fee", "PhoneNumber", "ReceiverName", "StaffNote", "Status", "Total", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "364 Cộng Hòa", 5000m, 1, new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hàng dễ bể", 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, "190029280", "Nguyễn Văn A", "", 3, 220000m, null, null },
                    { 2, 1, "113 Nguyễn Thái Sơn", 5000m, 1, new DateTime(2020, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Hàng dễ bể", 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, "190029280", "Nguyễn Văn B", "", 3, 220000m, null, null },
                    { 3, 1, "364 Cộng Hòa", 5000m, 1, new DateTime(2020, 7, 16, 14, 20, 56, 888, DateTimeKind.Local).AddTicks(1128), 2, "Hàng dễ bể", 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, "190029280", "Phạm Thị C", "", 2, 220000m, null, null },
                    { 4, 1, "364 Điện Biên Phủ", 5000m, 1, new DateTime(2020, 7, 16, 14, 20, 56, 888, DateTimeKind.Local).AddTicks(1145), 2, "Hàng dễ bể", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, "190029280", "Trần Văn D", "", 1, 220000m, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
