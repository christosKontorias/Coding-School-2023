namespace CarServiceCenter.Web.Mvc.Models.Engineer;

public class EngineerEditDto {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int SalaryPerMonth { get; set; }
    public int ManagerId { get; set; }

}