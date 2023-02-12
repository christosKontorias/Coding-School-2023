using CarServiceCenter.Web.Mvc.Models.TransactionLine;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace CarServiceCenter.Web.Mvc.Models.Transaction; 
public class TransactionCreateDto {
    public DateTime Date { get; set; }
	[DisplayName("Total Price")]
	public decimal TotalPrice { get; set; }
	[DisplayName("Customer Surname")]
	public int CustomerId { get; set; }
    public List<SelectListItem> Customers { get; set; } = new List<SelectListItem>();
	[DisplayName("Manager Surname")]
	public int ManagerId { get; set; }
    public List<SelectListItem> Managers { get; set; } = new List<SelectListItem>();
	[DisplayName("Car Model")]
	public int CarId { get; set; }
    public List<SelectListItem> Cars { get; set; } = new List<SelectListItem>();

    public List<SelectListItem> TransactionLines { get; set; } = new List<SelectListItem>();
}
