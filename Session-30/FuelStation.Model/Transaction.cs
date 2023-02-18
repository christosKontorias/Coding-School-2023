using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model; 
public class Transaction {

	//Properties 
	public int Id { get; set; }
	public DateTime Date { get; set; }
	public PaymentMethod PaymentMethod { get; set; }
	public decimal TotalValue { get; set; }

	//Constructor

	//Relations
	public int EmployeeId { get; set; }
	public Employee Employee { get; set; } = null!;
	public int CustomerId { get; set; }
	public Customer Customer { get; set; } = null!;
	public List<TransactionLine> TransactionLines { get; set; }
}
