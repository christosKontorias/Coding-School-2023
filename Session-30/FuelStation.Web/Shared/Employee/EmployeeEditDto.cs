using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.Employee {
	public class EmployeeEditDto {
		public int Id { get; set; }
		[Required]
		[MaxLength(50, ErrorMessage = "Name must have max length 50 letters.")]
		public string Name { get; set; }
		[Required]
		[MaxLength(50, ErrorMessage = "Surname must have max length 50 letters.")]
		public string Surname { get; set; }
		public DateTime HireDateStart { get; set; }
		public DateTime HireDateEnd { get; set; }
		public int SallaryPerMonth { get; set; }
		[Required]
		public EmployeeType EmployeeType { get; set; }
	}
}
