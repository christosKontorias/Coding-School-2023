using FuelStation.Model.Enums;
using FuelStation.Web.Shared.TransactionLine;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Web.Shared.Transaction {
	public  class TransactionListDto {
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		[DataType(DataType.Currency)]
		public decimal TotalValue { get; set; }
		public int EmployeeId { get; set; }
		public int CustomerId { get; set; }

		public List<TransactionLineListDto>? TransactionLines { get; set; } = new();
	}
}
