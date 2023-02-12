using CarServiceCenter.Web.Mvc.Models.TransactionLine;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace CarServiceCenter.Web.Mvc.Models.Transaction; 
	public class TransactionDetailsDto {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    [DisplayName("Total Price")]
    public decimal TotalPrice { get; set; }
    [DisplayName("Customer Id")]
    public int CustomerId { get; set; }
    [DisplayName("Manager Id")]
    public int ManagerId { get; set; }
    [DisplayName("Car Id")]
    public int CarId { get; set; }
	public List<CarServiceCenter.Model.TransactionLine> TransactionLines { get; set; } = new List<CarServiceCenter.Model.TransactionLine>();

}
