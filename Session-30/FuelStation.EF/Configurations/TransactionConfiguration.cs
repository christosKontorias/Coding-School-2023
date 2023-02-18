using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations;
public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {
	public void Configure(EntityTypeBuilder<Transaction> builder) {
		// Table Name
		builder.ToTable("Transactions");

		// Primary Key
		builder.HasKey(transaction => transaction.Id);
		builder.Property(transaction => transaction.Id).ValueGeneratedOnAdd();

		// Properties
		builder.Property(transaction => transaction.Date).IsRequired();
		builder.Property(transaction => transaction.PaymentMethod).IsRequired();
		builder.Property(transaction => transaction.TotalValue).HasPrecision(5, 2).IsRequired();
	
		//Relations
		builder.HasOne(transaction => transaction.Customer)
			.WithMany(transaction => transaction.Transactions)
			.HasForeignKey(transaction => transaction.CustomerId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne(transaction => transaction.Employee)
			.WithMany(transaction => transaction.Transactions)
			.HasForeignKey(transaction => transaction.EmployeeId)
			.OnDelete(DeleteBehavior.Restrict);

	}
}
