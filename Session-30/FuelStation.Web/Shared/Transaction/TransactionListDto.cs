using FuelStation.Model.Enums;

namespace FuelStation.Web.Shared.Transaction {
	public  class TransactionListDto {
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public PaymentMethod PaymentMethod { get; set; }
		public decimal TotalValue { get; set; }
		public int EmployeeId { get; set; }
		public int CustomerId { get; set; }

		public List<FuelStation.Model.TransactionLine> TransactionLines { get; set; } = new();
	}
}
