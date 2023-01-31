using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarServiceCenterLib.Orm.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_Transaction_TransactionID",
                table: "TransactionLine");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionLine",
                table: "TransactionLine");

            migrationBuilder.RenameTable(
                name: "TransactionLine",
                newName: "TransactionLines");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLine_TransactionID",
                table: "TransactionLines",
                newName: "IX_TransactionLines_TransactionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionLines",
                table: "TransactionLines",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "ServiceTask",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hours = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceTask", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CarID",
                table: "Transaction",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_ManagerID",
                table: "Transaction",
                column: "ManagerID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLines_EngineerID",
                table: "TransactionLines",
                column: "EngineerID");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLines_ServiceTaskID",
                table: "TransactionLines",
                column: "ServiceTaskID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Car_CarID",
                table: "Transaction",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customers_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Manager_ManagerID",
                table: "Transaction",
                column: "ManagerID",
                principalTable: "Manager",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Engineer_EngineerID",
                table: "TransactionLines",
                column: "EngineerID",
                principalTable: "Engineer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_ServiceTask_ServiceTaskID",
                table: "TransactionLines",
                column: "ServiceTaskID",
                principalTable: "ServiceTask",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLines_Transaction_TransactionID",
                table: "TransactionLines",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Car_CarID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customers_CustomerID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Manager_ManagerID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Engineer_EngineerID",
                table: "TransactionLines");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_ServiceTask_ServiceTaskID",
                table: "TransactionLines");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLines_Transaction_TransactionID",
                table: "TransactionLines");

            migrationBuilder.DropTable(
                name: "ServiceTask");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CarID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_ManagerID",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionLines",
                table: "TransactionLines");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLines_EngineerID",
                table: "TransactionLines");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLines_ServiceTaskID",
                table: "TransactionLines");

            migrationBuilder.RenameTable(
                name: "TransactionLines",
                newName: "TransactionLine");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLines_TransactionID",
                table: "TransactionLine",
                newName: "IX_TransactionLine_TransactionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionLine",
                table: "TransactionLine",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_Transaction_TransactionID",
                table: "TransactionLine",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
