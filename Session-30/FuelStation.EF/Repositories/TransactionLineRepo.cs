using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories;
public class TransactionLineRepo : IEntityRepo<TransactionLine> {
	public void Add(TransactionLine entity) {
		using var context = new FuelStationDbContext();
		if (entity.Id != 0) {
			throw new ArgumentException("Given entity should not have Id set", nameof(entity));
		}
		context.Add(entity);
		context.SaveChanges();
	}

	public void Delete(int id) {
		using var context = new FuelStationDbContext();
		var TransactionLineDb = context.TransactionLines.SingleOrDefault(transactionline => transactionline.Id == id);
		if (TransactionLineDb is null) {
			throw new KeyNotFoundException($"Given id'{id}' was not found in database");
		}
		context.Remove(TransactionLineDb);
		context.SaveChanges();
	}

	public IList<TransactionLine> GetAll() {
		using var context = new FuelStationDbContext();
		return context.TransactionLines
			.Include(transactionLine => transactionLine.Transaction)
			.Include(transactionLine => transactionLine.Item).ToList();
	}

	public TransactionLine? GetById(int id) {
		using var context = new FuelStationDbContext();
		return context.TransactionLines
		.Include(transactionLine => transactionLine.Transaction)
		.Include(transactionLine => transactionLine.Item)
		.SingleOrDefault(transactionline => transactionline.Id == id);
	}

	public void Update(int id, TransactionLine entity) {
		using var context = new FuelStationDbContext();
		var TransactionLineDb = context.TransactionLines.SingleOrDefault(transactionline => transactionline.Id == id);
		if (TransactionLineDb is null) {
			throw new KeyNotFoundException($"Given id '{id}' was not found in database");
		}
		TransactionLineDb.Quantity = entity.Quantity;
		TransactionLineDb.ItemPrice = entity.ItemPrice;
		TransactionLineDb.NetValue = entity.NetValue;
		TransactionLineDb.DiscountPercent = entity.DiscountPercent;
		TransactionLineDb.DiscountValue = entity.DiscountValue;
		TransactionLineDb.TotalValue = entity.TotalValue;
		//TransactionLineDb.Transaction = entity.Transaction;
		//TransactionLineDb.TransactionId = entity.TransactionId;
		//TransactionLineDb.Item = entity.Item;
		//TransactionLineDb.ItemId = entity.ItemId;
		context.SaveChanges();
	}
}
