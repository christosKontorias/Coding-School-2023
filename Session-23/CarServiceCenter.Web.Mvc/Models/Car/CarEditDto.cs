using System.ComponentModel;

namespace CarServiceCenter.Web.Mvc.Models.Car;

public class CarEditDto {
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    [DisplayName("Car Registration Number")]
    public string CarRegistrationNumber { get; set; }
}
