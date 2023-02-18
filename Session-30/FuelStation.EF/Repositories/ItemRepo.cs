using FuelStation.EF.Context;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Repositories;
public class ItemRepo : IEntityRepo<Item> {
	public void Add(Item entity) {
		using var context = new FuelStationDbContext();
		if (entity.Id != 0) {
			throw new ArgumentException("Given entity should not have Id set", nameof(entity));
		}
		context.Add(entity);
		context.SaveChanges();
	}

	public void Delete(int id) {
		using var context = new FuelStationDbContext();
		var ItemDb = context.Items.SingleOrDefault(item => item.Id == id);
		if (ItemDb is null) {
			throw new KeyNotFoundException($"Given id '{id}' was not found in database");
		}
		context.Remove(ItemDb);
		context.SaveChanges();
	}

	public IList<Item> GetAll() {
		using var context = new FuelStationDbContext();
		return context.Items.Include(item => item.TransactionLines).ToList();
	}

	public Item? GetById(int id) {
		using var context = new FuelStationDbContext();
		return context.Items.Include(item => item.TransactionLines)
			.SingleOrDefault(item => item.Id == id);
	}

	public void Update(int id, Item entity) {
		using var context = new FuelStationDbContext();
		var ItemDb = context.Items.SingleOrDefault(item => item.Id == id);
		if (ItemDb is null) {
			throw new KeyNotFoundException($"Given id '{id}' was not found in database");
		}
		ItemDb.Code = entity.Code;
		ItemDb.Description = entity.Description;
		ItemDb.ItemType = entity.ItemType;
		ItemDb.Price = entity.Price;
		ItemDb.Cost = entity.Cost;
		context.SaveChanges();
	}
}
