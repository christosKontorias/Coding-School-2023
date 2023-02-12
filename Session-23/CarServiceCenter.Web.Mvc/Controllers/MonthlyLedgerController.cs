using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
	public class MonthlyLedgerController : Controller {
		public IActionResult Index() {
			List<MonthlyLedger> list = new List<MonthlyLedger>();
			MonthlyLedger monthlyLedger;
			int year = DateTime.Now.Year;
			for (int month = 1; month <= 12; month++) {
				monthlyLedger = new MonthlyLedger(year, month);
				monthlyLedger.Expenses += SalaryEngineersFrom(year, month);
				monthlyLedger.Expenses += SalaryManagersFrom(year, month);
				monthlyLedger.Incomes = CalculateIncomes(year, month);
				monthlyLedger.Total = monthlyLedger.Incomes - monthlyLedger.Expenses;
				list.Add(monthlyLedger);
			}
			return View(model: list);
		}
		public decimal SalaryEngineersFrom(int Year, int Month) {
			decimal TotalSalary = 0;
			EngineerRepo engineerRepo = new EngineerRepo();
			List<Engineer> engineers = engineerRepo.GetAll().ToList();
			DateTime date = new DateTime(Year, Month, DateTime.DaysInMonth(Year, Month));
			foreach (Engineer engineer in engineers) {
				//if (((DateTime)engineer.StartDate) <= date) {
				//	TotalSalary += engineer.SalaryPerMonth;
				//}
			}
			return TotalSalary;
		}
		public decimal SalaryManagersFrom(int Year, int Month) {
			decimal TotalSalary = 0;
			ManagerRepo managerRepo = new ManagerRepo();
			List<Manager> managers = managerRepo.GetAll().ToList();
			DateTime date = new DateTime(Year, Month, DateTime.DaysInMonth(Year, Month));
			foreach (Manager manager in managers) {
				//if (((DateTime)manager.StartDate) <= date) {
				//	TotalSalary += manager.SalaryPerMonth;
				//}
			}
			return TotalSalary;
		}

		public decimal CalculateIncomes(int Year, int Month) {
			decimal retValue = 0;
			TransactionRepo transactionRepo = new TransactionRepo();
			List<Transaction> transactions = transactionRepo.GetAll().ToList();
			foreach (Transaction transaction in transactions) {
				if (transaction.Date.Year == Year && transaction.Date.Month == Month) {
					retValue += transaction.TotalPrice;
				}
			}
			return retValue;
		}
	}
}
