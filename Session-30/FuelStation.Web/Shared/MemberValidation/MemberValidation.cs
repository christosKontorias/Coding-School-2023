using FuelStation.Model;
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
			ManagersLimits = new MinMaxMembers() { Min = 0, Max = 3 };
			StaffLimits = new MinMaxMembers() { Min = 0, Max = 10 };
			CashiersLimits = new MinMaxMembers() { Min = 0, Max = 4 };
		}

		public bool ValidateDeleteEmployee(EmployeeType employeeType, List<Model.Employee> employees, out string errorMessage) {
			bool result = true;
			errorMessage = "Succeed";

			var managers = employees.Where(employees => employees.EmployeeType == EmployeeType.Manager);
			var staff = employees.Where(employees => employees.EmployeeType == EmployeeType.Staff);
			var cashiers = employees.Where(employees => employees.EmployeeType == EmployeeType.Cashier);

			if (employeeType == EmployeeType.Manager && managers.Count() <= ManagersLimits.Min) {
				errorMessage = $"The Fuel Station have the minimum of {ManagersLimits.Min} Managers. You cannot delete others!";
				result = false;
			}

			if (employeeType == EmployeeType.Staff && staff.Count() <= StaffLimits.Min) {
				errorMessage = $"The Fuel Station have the minimum of {StaffLimits.Min} Staff. You cannot delete others!";
				result = false;
			}

			if (employeeType == EmployeeType.Cashier && cashiers.Count() <= CashiersLimits.Min) {
				errorMessage = $"The Fuel Station have the minimum of {CashiersLimits.Min} Cashiers. You cannot delete others!";
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

				if (newEmployeeType == EmployeeType.Manager && managers.Count() >= ManagersLimits.Max) {
					errorMessage = $"Cannot update employee type. Fuel station has maximum of {ManagersLimits.Max} Managers!";
					result = false;
				}

				if (newEmployeeType == EmployeeType.Staff && staff.Count() >= StaffLimits.Max) {
					errorMessage = $"Cannot update employee type. Fuel station has maximum of {StaffLimits.Max} Staff!";
					result = false;
				}

				if (newEmployeeType == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max) {
					errorMessage = $"Cannot update employee type. Fuel station has maximum of {CashiersLimits.Max} Cashiers!";
					result = false;
				}
			}
			return result;
		}

		public bool ValidateCreateEmployee(EmployeeType employeeType, List<Model.Employee> employees, out string errorMessage) {
			bool result = true;
			errorMessage = "Succeed";

			var managers = employees.Where(employees => employees.EmployeeType == EmployeeType.Manager);
			var staff = employees.Where(employees => employees.EmployeeType == EmployeeType.Staff);
			var cashiers = employees.Where(employees => employees.EmployeeType == EmployeeType.Cashier);

			if (employeeType == EmployeeType.Manager && managers.Count() >= ManagersLimits.Max) {
				errorMessage = $"The Fuel Station have a maximum of {ManagersLimits.Max} Managers. You cannot add another Manager!";
				result = false;
			}

			if (employeeType == EmployeeType.Staff && staff.Count() >= StaffLimits.Max) {
				errorMessage = $"The Fuel Station have a maximum of {StaffLimits.Max} Staff. You cannot add another Staff Member!";
				result = false;
			}

			if (employeeType == EmployeeType.Cashier && cashiers.Count() >= CashiersLimits.Max) {
				errorMessage = $"The Fuel Station have a maximum of {CashiersLimits.Max} Cashiers. You cannot add another Cashier!";
				result = false;
			}

			return result;
		}
	}

	public struct MinMaxMembers {
		public int Min;
		public int? Max;
	}
}