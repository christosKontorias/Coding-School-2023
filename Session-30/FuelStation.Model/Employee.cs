using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model; 
public class Employee {

	//Properties
	public int Id { get; set; }
	public string Name { get; set; }
	public string Surname { get; set; }
	public DateTime HireDateStart { get; set; }
	public DateTime HireDateEnd { get;set; }
	public int SallaryPerMonth { get; set; }
	public EmployeeType EmployeeType { get; set; }

	//Constructor
	public Employee(string name, string surname, DateTime hireDateStart, DateTime hireDateEnd,int sallaryPerMonth, EmployeeType employeeType) {
		Name = name;
		Surname = surname;
		HireDateStart = hireDateStart;
		HireDateEnd = hireDateEnd;
		EmployeeType = employeeType;
		SallaryPerMonth = sallaryPerMonth;

		Transactions = new List<Transaction>();
	}
	//Relations
	public List<Transaction> Transactions { get; set; }
}