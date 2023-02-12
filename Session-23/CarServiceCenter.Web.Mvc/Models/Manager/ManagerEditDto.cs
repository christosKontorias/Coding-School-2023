using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Mvc.Models.Manager;

public class ManagerEditDto {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
	[DisplayName("Salary Per Month")]
	[Range(0, 5000, ErrorMessage = "Manager Salary cannot exceed 5000!")]
	public int SalaryPerMonth { get; set; }
}
