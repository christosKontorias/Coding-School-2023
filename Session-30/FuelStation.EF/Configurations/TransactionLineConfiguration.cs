using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations; 
public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>{
	public void Configure(EntityTypeBuilder<TransactionLine> builder) {
		// Table Name
		builder.ToTable("TransactionLines");

		// Primary Key
		builder.HasKey(transactionLine => transactionLine.Id);
		builder.Property(transactionLine => transactionLine.Id).ValueGeneratedOnAdd();

		// Properties
		builder.Property(transactionLine => transactionLine.Quantity).IsRequired();
		builder.Property(transactionLine => transactionLine.ItemPrice).HasPrecision(5, 2).IsRequired();
		builder.Property(transactionLine => transactionLine.NetValue).HasPrecision(6, 2).IsRequired();
		builder.Property(transactionLine => transactionLine.DiscountPercent).HasPrecision(4, 2).IsRequired();
		builder.Property(transactionLine => transactionLine.DiscountValue).HasPrecision(4, 2).IsRequired();
		builder.Property(transactionLine => transactionLine.TotalValue).HasPrecision(6, 2).IsRequired();

		// Relations
		builder.HasOne(transactionLine => transactionLine.Transaction)
			.WithMany(transactionLine => transactionLine.TransactionLines)
			.HasForeignKey(transactionLine => transactionLine.TransactionId)
			.OnDelete(DeleteBehavior.Restrict);

		builder.HasOne(transactionLine => transactionLine.Item)
			.WithMany(transactionLine => transactionLine.TransactionLines)
			.HasForeignKey(transactionLine => transactionLine.ItemId)
			.OnDelete(DeleteBehavior.Restrict);
	}
}
