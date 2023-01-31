﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceCenterLib.Models;

namespace CarServiceCenterLib.Orm.Configurations {
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine> {
        public void Configure(EntityTypeBuilder<TransactionLine> builder) {
            builder.ToTable("TransactionLines");
            builder.HasKey(transactionline => transactionline.ID);

            builder.HasOne(transactionline => transactionline.Transaction)
                 .WithMany(transaction => transaction.TransactionLines)
                 .HasForeignKey(transactionline => transactionline.TransactionID);

            builder.HasOne(transactionline => transactionline.Engineer)
                .WithMany(engineer => engineer.TransactionLines)
                .HasForeignKey(transactionline => transactionline.EngineerID);

            builder.HasOne(transactionline => transactionline.ServiceTask)
                .WithMany(servicetask => servicetask.TransactionLines)
                .HasForeignKey(transactionline => transactionline.ServiceTaskID);
        }
    }
}