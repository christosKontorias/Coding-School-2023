using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model; 
public class Ledger {

	//Properties
	public int Year { get; set; }
	public int Month { get; set; }
	public decimal Income { get; set; }
	public decimal Expenses { get; set; }
	public decimal Total { get; set; }

	public List<Transaction> Transactions { get; set; } = new List<Transaction>();


	public Ledger(DateTime datetime) {
		Year = datetime.Year;
		Month = datetime.Month;
	}
}
