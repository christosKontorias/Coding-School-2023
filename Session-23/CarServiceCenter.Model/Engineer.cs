using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Model;

public class Engineer
{
    public Engineer(string name, string surname, int salaryPerMonth)
    {
        Name = name;
        Surname = surname;
        SalaryPerMonth = salaryPerMonth;

        TransactionLines = new List<TransactionLine>();
    }

    public Engineer() {
        TransactionLines = new List<TransactionLine>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    [DisplayName("Salary Per Month")]
	[Range(0, 3000, ErrorMessage = "Salary cannot exceed 3000")]

	public int SalaryPerMonth { get; set; }

    // Relations
    public int ManagerId { get; set; }
    public Manager Manager { get; set; } = null!;

    public List<TransactionLine> TransactionLines { get; set; }
}
