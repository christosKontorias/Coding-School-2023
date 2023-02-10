using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {
        public void Add(Transaction entity) {
            using var context = new CarServiceCenterDbContext();

            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Transactions.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var TransactionDb = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (TransactionDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            context.Remove(TransactionDb);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions.ToList();
        }

        public Transaction? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            var TransactionDb = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (TransactionDb is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return TransactionDb;
            }
        }

        public void Update(int id, Transaction entity) {
            using var context = new CarServiceCenterDbContext();
            var TransactionDb = context.Transactions.Where(transaction => transaction.Id == id).SingleOrDefault();
            if (TransactionDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            TransactionDb.Date = entity.Date;
            TransactionDb.CustomerId = entity.CustomerId;
            TransactionDb.CarId = entity.CarId;
            TransactionDb.ManagerId = entity.ManagerId;
            TransactionDb.TotalPrice = entity.TotalPrice;
            context.SaveChanges();
        }
    }
}
