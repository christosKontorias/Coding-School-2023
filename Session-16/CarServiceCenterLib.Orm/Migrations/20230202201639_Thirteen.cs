using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarServiceCenterLib.Orm.Migrations
{
    /// <inheritdoc />
    public partial class Thirteen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_TransactionLine_Engineer_EngineerID",
                table: "TransactionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_ServiceTask_ServiceTaskID",
                table: "TransactionLine");

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

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLine_ServiceTaskID",
                table: "TransactionLines",
                newName: "IX_TransactionLines_ServiceTaskID");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLine_EngineerID",
                table: "TransactionLines",
                newName: "IX_TransactionLines_EngineerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionLines",
                table: "TransactionLines",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Car_CarID",
                table: "Transaction",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customers_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Manager_ManagerID",
                table: "Transaction",
                column: "ManagerID",
                principalTable: "Manager",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionLines",
                table: "TransactionLines");

            migrationBuilder.RenameTable(
                name: "TransactionLines",
                newName: "TransactionLine");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLines_TransactionID",
                table: "TransactionLine",
                newName: "IX_TransactionLine_TransactionID");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLines_ServiceTaskID",
                table: "TransactionLine",
                newName: "IX_TransactionLine_ServiceTaskID");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionLines_EngineerID",
                table: "TransactionLine",
                newName: "IX_TransactionLine_EngineerID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionLine",
                table: "TransactionLine",
                column: "ID");

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
                name: "FK_TransactionLine_Engineer_EngineerID",
                table: "TransactionLine",
                column: "EngineerID",
                principalTable: "Engineer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_ServiceTask_ServiceTaskID",
                table: "TransactionLine",
                column: "ServiceTaskID",
                principalTable: "ServiceTask",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_Transaction_TransactionID",
                table: "TransactionLine",
                column: "TransactionID",
                principalTable: "Transaction",
                principalColumn: "ID");
        }
    }
}
