using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.MemberValidation {
	public class MemberValidation : IMemberValidation {
		public readonly MinMaxMembers ManagersLimits;
		public readonly MinMaxMembers StaffLimits;
		public readonly MinMaxMembers CashiersLimits;


		public MemberValidation() {
			ManagersLimits = new MinMaxMembers() { Min = 3, Max = null };
			StaffLimits = new MinMaxMembers() { Min = 10, Max = null };
			CashiersLimits = new MinMaxMembers() { Min = 4, Max = null };
		}


		public bool ValidateDeleteEmployee(EmployeeType employeeType, List<Model.Employee> employees, out string errorMessage) {
			bool result = true;
			errorMessage = "Succeed";

			var managers = employees.Where(employees => employees.EmployeeType == EmployeeType.Manager);
			var staff = employees.Where(employees => employees.EmployeeType == EmployeeType.Staff);
			var cashiers = employees.Where(employees => employees.EmployeeType == EmployeeType.Cashier);

			if (employeeType == EmployeeType.Manager && managers.Count() <= ManagersLimits.Min) {
				errorMessage = $"Fuel Station can have up to {ManagersLimits.Min} Managers. You cannot delete others!";
				result = false;
			}

			if (employeeType == EmployeeType.Staff && staff.Count() <= StaffLimits.Min) {
				errorMessage = $"Fuel Station can have up to {StaffLimits.Min} Staff. You cannot delete others!";
				result = false;
			}

			if (employeeType == EmployeeType.Cashier && cashiers.Count() <= CashiersLimits.Min) {
				errorMessage = $"Fuel Station can have up to {CashiersLimits.Min} Cashiers. You cannot delete others!";
				result = false;
			}

			return result;
		}

		public bool ValidateUpdateEmployee(EmployeeType newEmployeeType, Model.Employee EmployeeDb, List<Model.Employee> employees, out string errorMessage) {
			bool result = true;
			errorMessage = "Succeed";

			if (EmployeeDb == null) {
				result = false;
			} else if (newEmployeeType != EmployeeDb.EmployeeType) {
				var managers = employees.Where(employees => employees.EmployeeType == EmployeeType.Manager);
				var staff = employees.Where(employees => employees.EmployeeType == EmployeeType.Staff);
				var cashiers = employees.Where(employees => employees.EmployeeType == EmployeeType.Cashier);

				if (EmployeeDb.EmployeeType == EmployeeType.Manager && managers.Count() <= ManagersLimits.Min) {
					errorMessage = $"Cannot update employee type. Fuel station has minimum {ManagersLimits.Min} Managers!";
					result = false;
				}

				if (EmployeeDb.EmployeeType == EmployeeType.Staff && staff.Count() <= StaffLimits.Min) {
					errorMessage = $"Cannot update employee type. Fuel station has minimum {StaffLimits.Min} Staff!";
					result = false;
				}

				if (EmployeeDb.EmployeeType == EmployeeType.Cashier && cashiers.Count() <= CashiersLimits.Min) {
					errorMessage = $"Cannot update employee type. Fuel station has minimum {CashiersLimits.Min} Cashiers!";
					result = false;
				}

				if (result) {
					// Check if the new employee type meets the minimum requirement
					if (newEmployeeType == EmployeeType.Manager && managers.Count() <= ManagersLimits.Max) {
						errorMessage = $"Cannot update employee type. Fuel station has minimum {ManagersLimits.Min} Managers!";
						result = false;
					} else if (newEmployeeType == EmployeeType.Staff && staff.Count() <= StaffLimits.Max) {
						errorMessage = $"Cannot update employee type. Fuel station has minimum {StaffLimits.Min} Staff!";
						result = false;
					} else if (newEmployeeType == EmployeeType.Cashier && cashiers.Count() <= CashiersLimits.Min) {
						errorMessage = $"Cannot update employee type. Fuel station has minimum {CashiersLimits.Max} Cashiers!";
						result = false;
					}
				}
			}
			return result;
		}
	}

	public struct MinMaxMembers {
		public int Min;
		public int? Max;
	}
}