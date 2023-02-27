using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;

namespace FuelStation.Web.Shared.TransactionLine {
	public class TransactionLineEditDto {
		public int Id { get; set; }
		public int Quantity { get; set; }
		public decimal ItemPrice { get; set; }
		public decimal NetValue { get; set; }
		public decimal DiscountPercent { get; set; }
		public decimal DiscountValue { get; set; }
		[DataType(DataType.Currency)]
		public decimal TotalValue { get; set; }
		public int TransactionId { get; set; }
		public int ItemId { get; set; }

		public TransactionLineEditDto(int quantity, decimal itemPrice, decimal netValue, decimal discountPercent
			, decimal discountValue, decimal totalValue) {

			Quantity = quantity;
			ItemPrice = itemPrice;
			NetValue = netValue;
			DiscountPercent = discountPercent;
			DiscountValue = discountValue;
			TotalValue = totalValue;

		}
	}
}
