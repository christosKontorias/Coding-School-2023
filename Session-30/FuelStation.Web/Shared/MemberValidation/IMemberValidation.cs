using FuelStation.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Web.Shared.MemberValidation {
	public interface IMemberValidation {
		bool ValidateDeleteEmployee(EmployeeType employeeType, List<FuelStation.Model.Employee> employees, out String errorMessage);
		bool ValidateUpdateEmployee(EmployeeType newEmployeeType, FuelStation.Model.Employee EmployeeDb, List<FuelStation.Model.Employee> employees, out String errorMessage);
	}
}
