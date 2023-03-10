using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.Item {
	public class ItemListDto {
		public int Id { get; set; }
		public string Code { get; set; }
		public string Description { get; set; }
		public ItemType ItemType { get; set; }
		[DataType(DataType.Currency)]
		public decimal Price { get; set; }
		[DataType(DataType.Currency)]
		public decimal Cost { get; set; }
	}
}
