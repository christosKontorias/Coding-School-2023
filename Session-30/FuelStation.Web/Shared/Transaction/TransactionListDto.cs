using FuelStation.Model.Enums;
using FuelStation.Web.Shared.TransactionLine;

namespace FuelStation.Web.Shared.Transaction {
	public  class TransactionListDto {
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		public decimal TotalValue { get; set; }
		public int EmployeeId { get; set; }
		public int CustomerId { get; set; }

		public List<TransactionLineListDto>? TransactionLines { get; set; } = new();
	}
}
