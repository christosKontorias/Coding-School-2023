using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Web.Mvc.Models.Engineer;

public class EngineerCreateDto {
    public string Name { get; set; }
    public string Surname { get; set; }
    [DisplayName("Salary Per Month")]
	[Range(0, 3000, ErrorMessage = "Engineer Salary cannot exceed 3000!")]
	public int SalaryPerMonth { get; set; }
    public int ManagerId { get; set; }
    public List<SelectListItem> Managers { get; } = new List<SelectListItem>();
}
