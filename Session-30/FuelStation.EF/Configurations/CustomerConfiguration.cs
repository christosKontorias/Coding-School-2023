using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FuelStation.EF.Configurations; 
public class CustomerConfiguration : IEntityTypeConfiguration<Customer>{
	public void Configure(EntityTypeBuilder<Customer> builder) {
		//Table Name
		builder.ToTable("Customers");

		//Primary Key
		builder.HasKey(customer => customer.Id);
		builder.Property(customer => customer.Id).ValueGeneratedOnAdd();

		//Properties
		builder.Property(customer => customer.Name).HasMaxLength(50).IsRequired();
		builder.Property(customer => customer.Surname).HasMaxLength(50).IsRequired();
		builder.Property(customer => customer.CardNumber).HasMaxLength(20).IsRequired();

		// Unique constraint on CardNumber (Den xerw akoma)
		//builder.HasIndex(c => c.CardNumber).IsUnique();
	}
}
