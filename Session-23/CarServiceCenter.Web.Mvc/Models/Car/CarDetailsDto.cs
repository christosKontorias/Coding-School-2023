using CarServiceCenter.Model;

namespace CarServiceCenter.Web.Mvc.Models.Car;

public class CarDetailsDto {
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string CarRegistrationNumber { get; set; }
    public List<Transaction> Transactions { get; set; } = new List<Transaction>();
}