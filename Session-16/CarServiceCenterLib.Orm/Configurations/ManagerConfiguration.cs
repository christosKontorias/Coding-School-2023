using CarServiceCenterLib.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLib.Orm.Configurations {
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager> {
        public void Configure(EntityTypeBuilder<Manager> builder) {
            builder.ToTable("Manager");
            builder.HasKey(manager => manager.ID);
            builder.Property(manager => manager.Name).HasMaxLength(50);
            builder.Property(manager => manager.Surname).HasMaxLength(50);
        }
    }
}