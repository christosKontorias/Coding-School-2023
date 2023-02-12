using CarServiceCenter.Web.Mvc.Models.TransactionLine;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenter.Web.Mvc.Models.Transaction; 
public class TransactionCreateDto {
    public DateTime Date { get; set; }
    //public decimal TotalPrice { get; set; }
    public int CustomerId { get; set; }
    public List<SelectListItem> Customers { get; } = new List<SelectListItem>();

    public int ManagerId { get; set; }
    public List<SelectListItem> Managers { get; } = new List<SelectListItem>();

    public int CarId { get; set; }
    public List<SelectListItem> Cars { get; } = new List<SelectListItem>();

    public List<SelectListItem> TransactionLines { get; } = new List<SelectListItem>();
}
