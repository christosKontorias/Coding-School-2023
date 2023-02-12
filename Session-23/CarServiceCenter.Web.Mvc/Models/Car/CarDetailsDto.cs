using CarServiceCenter.Model;
using System.ComponentModel;

namespace CarServiceCenter.Web.Mvc.Models.Car;

public class CarDetailsDto {
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    [DisplayName("Car Registration Number")]
    public string CarRegistrationNumber { get; set; }
    //public List<Transaction> Transactions { get; set; } = new List<Transaction>();
}