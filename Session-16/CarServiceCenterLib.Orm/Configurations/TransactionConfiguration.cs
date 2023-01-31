using CarServiceCenterLib.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLib.Orm.Configurations {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {
            builder.ToTable("Transaction");
            builder.HasKey(transaction => transaction.ID);

            builder.HasMany(transaction => transaction.TransactionLines)
                .WithOne(transactionline => transactionline.Transaction)
                .HasForeignKey(transactionline => transactionline.TransactionID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(transaction => transaction.Car)
                .WithMany(car => car.Transactions)
                .HasForeignKey(transaction => transaction.CarID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(transaction => transaction.Customer)
                .WithMany(customer => customer.Transactions)
                .HasForeignKey(transaction => transaction.CustomerID)
                .OnDelete(DeleteBehavior.ClientSetNull);


            builder.HasOne(transaction => transaction.Manager)
                .WithMany(manager => manager.Transactions)
                .HasForeignKey(transaction => transaction.ManagerID)
                .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
