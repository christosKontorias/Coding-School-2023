using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model; 
public class Customer {

	//Properties
	public int Id { get; set; }
	public string Name { get; set; }
	public string Surname { get; set; }
	public string CardNumber { get; set; }

	//Constructor
	public Customer(string name, string surname, string cardNumber) {
		Name = name;
		Surname = surname;
		CardNumber = cardNumber;

		Transactions = new List<Transaction>();
	}
	//Relations
	public List<Transaction> Transactions { get; set; }
}