using FuelStation.Model.Enums;
using FuelStation.Web.Shared.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.Employee {
	public class EmployeeListDto {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public DateTime HireDateStart { get; set; }
		public DateTime HireDateEnd { get; set; }
		public int SallaryPerMonth { get; set; }
		public EmployeeType EmployeeType { get; set; }

		public List<TransactionListDto> transactionListDtos { get; set; }

	}
}
