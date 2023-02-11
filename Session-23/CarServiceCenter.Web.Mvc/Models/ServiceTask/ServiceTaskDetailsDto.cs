namespace CarServiceCenter.Web.Mvc.Models.ServiceTask;

public class ServiceTaskDetailsDto {
    public int Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public decimal Hours { get; set; }

    //public List<TransactionLine> TransactionLines { get; set; } = new List<TransactionLine>();

}