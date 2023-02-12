using CarServiceCenter.Web.Mvc.Models.TransactionLine;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenter.Web.Mvc.Models.Transaction; 
	public class TransactionDetailsDto {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public decimal TotalPrice { get; set; }
    public int CustomerId { get; set; }
    public int ManagerId { get; set; }
    public int CarId { get; set; }
	public List<CarServiceCenter.Model.TransactionLine> TransactionLines { get; set; } = new List<CarServiceCenter.Model.TransactionLine>();

}
