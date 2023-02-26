using FuelStation.Web.Shared.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.Customer {
	public class CustomerListDto {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
		public string CardNumber { get; set; }

		public List<TransactionListDto> transactionListDtos { get; set; }

	}
}