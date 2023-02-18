using System;
using FuelStation.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.EF.Context;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace FuelStation.EF.Repositories;
public class TransactionRepo : IEntityRepo<Transaction> {
	public void Add(Transaction entity) {
		using var context = new FuelStationDbContext();
		if (entity.Id != 0) {
			throw new ArgumentException("Given entity should Have ID set,", nameof(entity));
		}
		context.Add(entity);
		context.SaveChanges();
	}

	public void Delete(int id) {
		using var context = new FuelStationDbContext();
		var TransactionDb = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);
		if (TransactionDb is null) {
			throw new KeyNotFoundException($"Given id'{id}' was not found in database");
		}
		context.Remove(TransactionDb);
		context.SaveChanges();
	}

	public IList<Transaction> GetAll() {
		using var context = new FuelStationDbContext();
		var transactions = context.Transactions
			.Include(transaction => transaction.Customer)
			.Include(transaction => transaction.Employee)
			.Include(transaction => transaction.TransactionLines)
			.ToList();
		return transactions;
	}

	public Transaction? GetById(int id) {
		using var context = new FuelStationDbContext();
		return context.Transactions
			.Include(transaction => transaction.Customer)
			.Include(transaction => transaction.Employee)
			.Include(Transaction => Transaction.TransactionLines)
			.SingleOrDefault(transaction => transaction.Id == id);
	}

	public void Update(int id, Transaction entity) {
		using var context = new FuelStationDbContext();
		var TransactionDb = context.Transactions
			.Include(Transaction => Transaction.TransactionLines)
			.SingleOrDefault(transaction => transaction.Id == id);
		if (TransactionDb is null) {
			throw new KeyNotFoundException($"Given id '{id}' was not found in database");
		}
		TransactionDb.Date = entity.Date;
		TransactionDb.PaymentMethod = entity.PaymentMethod;
		TransactionDb.TotalValue = entity.TotalValue;
		TransactionDb.CustomerId = entity.CustomerId;
		TransactionDb.EmployeeId = entity.EmployeeId;
		TransactionDb.TransactionLines = entity.TransactionLines;
		context.SaveChanges();
	}
}
