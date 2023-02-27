using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.Item {
	public class ItemEditDto {
		public int Id { get; set; }
		[Required]
		[MaxLength(20, ErrorMessage = "Code must have max length 20 characters.")]
		public string Code { get; set; }
		[Required]
		[MaxLength(100, ErrorMessage = "Description must have max length 100 characters.")]
		public string Description { get; set; }
		[Required]
		public ItemType ItemType { get; set; }
		[Required]
		[Range(1, 99, ErrorMessage = "The Price must be from 1 to 99.")]
		public decimal Price { get; set; }
		[Required]
		[Range(1, 99, ErrorMessage = "The Cost must be from 1 to 99.")]
		public decimal Cost { get; set; }
	}
}
