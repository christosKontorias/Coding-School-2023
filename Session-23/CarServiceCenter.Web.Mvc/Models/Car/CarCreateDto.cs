using System.ComponentModel;

namespace CarServiceCenter.Web.Mvc.Models.Car;

public class CarCreateDto {
    public string Brand { get; set; }
    public string Model { get; set; }
    [DisplayName("Car Registration Number")]
    public string CarRegistrationNumber { get; set;}
}
