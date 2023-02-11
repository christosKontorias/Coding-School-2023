

using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenter.Web.Mvc.Models.Engineer;

public class EngineerCreateDto {
    public string Name { get; set; }
    public string Surname { get; set; }
    public int SalaryPerMonth { get; set; }
    //selector theloume kai mia lista 
    public int ManagerId { get; set; }
    public List<SelectListItem> Managers { get; } = new List<SelectListItem>();
}
