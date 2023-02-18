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
	//decimal SallaryPerMonth
	public EmployeeType EmployeeType { get; set; }

	//Constructor

	//Relations
}