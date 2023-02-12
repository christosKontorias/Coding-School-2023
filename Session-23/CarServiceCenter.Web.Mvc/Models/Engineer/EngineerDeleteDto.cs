using System.ComponentModel;

namespace CarServiceCenter.Web.Mvc.Models.Engineer;

public class EngineerDeleteDto {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    [DisplayName("Salary Per Month")]
    public int SalaryPerMonth { get; set; }
    public int ManagerId { get; set; }

}
