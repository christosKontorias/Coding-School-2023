using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;

namespace CarServiceCenter.Web.Mvc.Models.Transaction {
    public class TransactionDeleteDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [DisplayName("Total Price")]
        public decimal TotalPrice { get; set; }
        [DisplayName("Customer Id")]
        public int CustomerId { get; set; }
        public List<SelectListItem> Customers { get; } = new List<SelectListItem>();
        [DisplayName("Manager Id")]
        public int ManagerId { get; set; }
        public List<SelectListItem> Managers { get; } = new List<SelectListItem>();
        [DisplayName("Car Id")]
        public int CarId { get; set; }
        public List<SelectListItem> Cars { get; } = new List<SelectListItem>();
        public List<SelectListItem> TransactionLines { get; } = new List<SelectListItem>();
    }
}
