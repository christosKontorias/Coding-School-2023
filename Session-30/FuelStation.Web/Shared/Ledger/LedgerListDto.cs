using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.Ledger {
	public class LedgerListDto {
		public int Year { get; set; }
		public int Month { get; set; }
		public decimal Income { get; set; }
		public decimal Expenses { get; set; }
		public decimal Total { get; set; }

		public LedgerListDto(DateTime date) {
			Year = date.Year;
			Month = date.Month;
		}

		public void UpdateLedger(decimal income, decimal expenses) {
			Income = income;
			Expenses = expenses;
			Total = income - expenses;
		}
	}
}
