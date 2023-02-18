using FuelStation.EF.Configurations;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Context;
public class FuelStationDbContext : DbContext {

	public DbSet<Customer> Customers { get; set; } = null!;
	public DbSet<Employee> Employees { get; set; } = null!;
	public DbSet<Item> items { get; set; } = null!;
	public DbSet<Transaction> transactions { get; set; } = null!;
	public DbSet<TransactionLine> TransactionLines { get; set; } = null!;

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		modelBuilder.ApplyConfiguration(new CustomerConfiguration());
		modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
		modelBuilder.ApplyConfiguration(new ItemConfiguration());
		modelBuilder.ApplyConfiguration(new TransactionConfiguration());
		modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
		optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CoffeeShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
		base.OnConfiguring(optionsBuilder);
	}
}
