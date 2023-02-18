using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories;
public class EmployeeRepo : IEntityRepo<Employee> {
	public void Add(Employee entity) {
		using var context = new FuelStationDbContext();
		if (entity.Id != 0) {
			throw new ArgumentException("Given entity should not have Id set", nameof(entity));
		}
		context.Add(entity);
		context.SaveChanges();
	}

	public void Delete(int id) {
		using var context = new FuelStationDbContext();
		var EmployeeDb = context.Employees.Where(employee => employee.Id == id).SingleOrDefault();
		if (EmployeeDb is null) {
			throw new KeyNotFoundException($"Given id '{id}' was not found in database");
		}
		context.Remove(EmployeeDb);
		context.SaveChanges();
	}

	public IList<Employee> GetAll() {
		using var context = new FuelStationDbContext();
		return context.Employees.Include(employee => employee.Transactions).ToList();
	}

	public Employee? GetById(int id) {
		using var context = new FuelStationDbContext();
		return context.Employees.Include(employee => employee.Transactions).
			SingleOrDefault(employee => employee.Id == id);
	}

	public void Update(int id, Employee entity) {
		using var context = new FuelStationDbContext();
		var EmployeeDb = context.Employees
			.Include(employee => employee.Transactions)
			.Where(employee => employee.Id == id).SingleOrDefault();
		if (EmployeeDb is null) {
			throw new KeyNotFoundException($"Given id '{id}' was not found in database");
		}
		EmployeeDb.Name = entity.Name;
		EmployeeDb.Surname = entity.Surname;
		EmployeeDb.HireDateStart = entity.HireDateStart;
		EmployeeDb.HireDateEnd = entity.HireDateEnd;
		EmployeeDb.SallaryPerMonth = entity.SallaryPerMonth;
		EmployeeDb.EmployeeType = entity.EmployeeType;
		context.SaveChanges();
	}
}
