﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Model;

public class Manager
{
    public Manager(string name, string surname, int salaryPerMonth)
    {
        Name = name;
        Surname = surname;
        SalaryPerMonth = salaryPerMonth;

        Engineers = new List<Engineer>();
        Transactions = new List<Transaction>();
    }

    public Manager() {

    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
	[DisplayName("Salary Per Month")]
	public int SalaryPerMonth { get; set; }

    public List<Engineer> Engineers { get; set; }

    public List<Transaction> Transactions { get; set; }
}
