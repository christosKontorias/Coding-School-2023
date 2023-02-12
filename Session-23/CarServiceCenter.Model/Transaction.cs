using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarServiceCenter.Model;

public class Transaction
{
    public Transaction(decimal totalPrice)
    {
        Date = DateTime.Now;
        TotalPrice = totalPrice;

        TransactionLines = new List<TransactionLine>();
    }

    public Transaction() {

    }

    public int Id { get; set; }
    public DateTime Date { get; set; }
	[DisplayName("Total Price")]
	public decimal TotalPrice { get; set; }

    // Relations
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;
    public int ManagerId { get; set; }
    public Manager Manager { get; set; } = null!;
    public int CarId { get; set; }
    public Car Car { get; set; } = null!;

    public List<TransactionLine> TransactionLines { get; set; }
}

