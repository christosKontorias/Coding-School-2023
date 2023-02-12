using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace CarServiceCenter.Web.Mvc.Models.Transaction; 
public class TransactionEditDto {
    public int Id { get; set; }
    public DateTime Date { get; set; }
    [DisplayName("Total Price")]
    public decimal TotalPrice { get; set; }
    [DisplayName("Customer Surname")]
    public int CustomerId { get; set; }
    [DisplayName("Manager Surname")]
    public int ManagerId { get; set; }
    [DisplayName("Car Model")]
    public int CarId { get; set; }

}
