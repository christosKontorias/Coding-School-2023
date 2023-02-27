using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Model.Enums;
using FuelStation.Web.Shared.Employee;
using FuelStation.Web.Shared.MemberValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FuelStation.Web.Server.Controllers {
	[Route("[controller]")]
	[ApiController]
	public class EmployeeController : ControllerBase {
		private readonly IEntityRepo<Employee> _employeeRepo;
		private readonly IMemberValidation _memberValidation;
		public String errorMessage = String.Empty;

		public EmployeeController(IEntityRepo<Employee> employeeRepo, IMemberValidation memberValidation) {
			_employeeRepo = employeeRepo;
			_memberValidation = memberValidation;
		}

		[HttpGet]
		public async Task<IEnumerable<EmployeeListDto>> Get() {
			var result = _employeeRepo.GetAll();
			return result.Select(employee => new EmployeeListDto {
				Id = employee.Id,
				Name = employee.Name,
				Surname = employee.Surname,
				HireDateStart = employee.HireDateStart,
				HireDateEnd = employee.HireDateEnd,
				SallaryPerMonth = employee.SallaryPerMonth,
				EmployeeType = employee.EmployeeType
			});
		}

		[HttpGet("{id}")]
		public async Task<EmployeeEditDto> GetById(int id) {
			var result = _employeeRepo.GetById(id);
			return new EmployeeEditDto {
				Id = id,
				Name = result.Name,
				Surname = result.Surname,
				HireDateStart = result.HireDateStart,
				HireDateEnd = result.HireDateEnd,
				SallaryPerMonth = result.SallaryPerMonth,
				EmployeeType = result.EmployeeType
			};
		}

		[HttpPost]
		public async Task Post(EmployeeEditDto employee) {
			var newEmployee = new Employee(employee.Name, employee.Surname, employee.HireDateStart, employee.HireDateEnd, employee.SallaryPerMonth, employee.EmployeeType);
			_employeeRepo.Add(newEmployee);
		}


		[HttpPut]
		public async Task<ActionResult> Put(EmployeeEditDto employee) {
			var EmployeeDb = await Task.Run(() => { return _employeeRepo.GetById(employee.Id); });
			if (EmployeeDb == null) {
				return BadRequest($"Employee not found");
			} else if (_memberValidation.ValidateUpdateEmployee(employee.EmployeeType, EmployeeDb, _employeeRepo.GetAll().ToList(), out errorMessage)) {
				EmployeeDb.Name = employee.Name;
				EmployeeDb.Surname = employee.Surname;
				EmployeeDb.HireDateStart = employee.HireDateStart;
				EmployeeDb.HireDateEnd = employee.HireDateEnd;
				EmployeeDb.SallaryPerMonth = employee.SallaryPerMonth;
				EmployeeDb.EmployeeType = employee.EmployeeType;
				try {
					_employeeRepo.Update(employee.Id, EmployeeDb);
				} catch (DbUpdateException ex) {
					return BadRequest(ex.Message);
				}
				return Ok();
			} else {
				return BadRequest(errorMessage);
			}
		}

		//[HttpDelete("{id}")]
		//public async Task<ActionResult> Delete(int id) {

		//	var employees = _employeeRepo.GetAll().ToList();
		//	if (_memberValidation.ValidateDeleteEmployee(employees.Where(e => e.Id == id).Single().EmployeeType, employees, out errorMessage)) {
		//		try {
		//			await Task.Run(() => { _employeeRepo.Delete(id); });
		//		} catch (DbUpdateException) {
		//			return BadRequest($"Could not delete this employee because it has transactions");
		//		} catch (KeyNotFoundException) {
		//			return BadRequest($"Employee not found");
		//		}
		//		return Ok();
		//	}
		//	return BadRequest(errorMessage);
		//}

		[HttpDelete("{id}")]

		public async Task Delete(int id) {
			_employeeRepo.Delete(id);
		}
	}
}
