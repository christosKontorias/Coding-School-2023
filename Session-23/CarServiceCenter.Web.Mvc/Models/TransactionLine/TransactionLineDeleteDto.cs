using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenter.Web.Mvc.Models.TransactionLine; 
public class TransactionLineDeleteDto {
	public int Id { get; set; }
	public decimal Hours { get; set; }
	public decimal PricePerHour { get; set; }
	public decimal Price { get; set; }

	public int TransactionId { get; set; }
	public List<SelectListItem> Transactions { get; } = new List<SelectListItem>();

	public int ServiceTaskId { get; set; }
	public List<SelectListItem> ServiceTasks { get; } = new List<SelectListItem>();

	public int EngineerId { get; set; }
	public List<SelectListItem> Engineers { get; } = new List<SelectListItem>();
}
