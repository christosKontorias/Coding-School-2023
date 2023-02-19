using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Model; 
public class Item {

	//Properties
	public int Id { get; set; }
	public string Code { get; set; }
	public string Description { get; set; }
	public ItemType ItemType { get; set; }
	public decimal Price { get; set; }
	public decimal Cost { get; set; }

	//Constructor
	public Item(String code, String description, ItemType itemType, decimal price, decimal cost) {
		Code = code;
		Description = description;
		ItemType = itemType;
		Price = price;
		Cost = cost;
	}
	//Relations
	public List<TransactionLine> TransactionLines { get; set; }
}