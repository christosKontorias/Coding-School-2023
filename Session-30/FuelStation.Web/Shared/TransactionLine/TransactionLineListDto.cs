using FuelStation.Web.Shared.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.TransactionLine {
	public class TransactionLineListDto {
		public int Id { get; set; }
		public int Quantity { get; set; }
		[DataType(DataType.Currency)]
		public decimal ItemPrice { get; set; }
		[DataType(DataType.Currency)]
		public decimal NetValue { get; set; }
		public decimal DiscountPercent { get; set; }
		public decimal DiscountValue { get; set; }
		[DataType(DataType.Currency)]
		public decimal TotalValue { get; set; }
		public int TransactionId { get; set; }
		public int ItemId { get; set; }

		public ItemListDto? item { get; set; }

		public List<TransactionLineListDto> TransactionLines { get; set; } = new();
	}
}
