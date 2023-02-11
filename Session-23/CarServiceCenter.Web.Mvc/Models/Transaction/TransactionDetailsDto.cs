using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenter.Web.Mvc.Models.Transaction {
    public class TransactionDetailsDto {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public int CustomerId { get; set; }
        public int ManagerId { get; set; }
        public int CarId { get; set; }
        public List<SelectListItem> TransactionLines { get; set; } = new List<SelectListItem>();
    }
}
