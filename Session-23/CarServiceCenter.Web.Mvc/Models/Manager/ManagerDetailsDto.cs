using System.ComponentModel;

namespace CarServiceCenter.Web.Mvc.Models.Manager;

public class ManagerDetailsDto {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
	[DisplayName("Salary Per Month")]
	public int SalaryPerMonth { get; set; }
   // public List<Transaction> Transactions { get; set; } = new List<Transaction>();
}