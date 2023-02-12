﻿using CarServiceCenter.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarServiceCenter.EF.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            // Table Name
            builder.ToTable("Cars");

            // Primary Key
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(t => t.Brand).HasMaxLength(15).IsRequired();
            builder.Property(t => t.Model).HasMaxLength(15).IsRequired();
            builder.Property(t => t.CarRegistrationNumber).HasMaxLength(8).IsRequired();

            // Relations

        }
    }
}
