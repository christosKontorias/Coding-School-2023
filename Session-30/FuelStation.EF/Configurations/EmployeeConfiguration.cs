using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FuelStation.EF.Configurations;
public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>{
	public void Configure(EntityTypeBuilder<Employee> builder) {
		// Table Name
		builder.ToTable("Employees");

		// Primary Key
		builder.HasKey(employee => employee.Id);
		builder.Property(employee => employee.Id).ValueGeneratedOnAdd();

		// Properties
		builder.Property(employee => employee.Name).HasMaxLength(50).IsRequired();
		builder.Property(employee => employee.Surname).HasMaxLength(50).IsRequired();
		builder.Property(employee => employee.HireDateStart).IsRequired();
		builder.Property(employee => employee.HireDateEnd);
		builder.Property(employee => employee.SallaryPerMonth).IsRequired();
		builder.Property(employee => employee.EmployeeType).IsRequired();
	}
}