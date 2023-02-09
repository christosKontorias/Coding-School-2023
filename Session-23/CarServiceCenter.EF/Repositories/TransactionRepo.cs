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
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var TransactionDb = context.Transactions.Where(transaction => transaction.Id == id).Include(transaction => transaction.TransactionLines).SingleOrDefault();
            if (TransactionDb is null)
                return;
            context.Remove(TransactionDb);
            context.SaveChanges();
        }

        public IList<Transaction> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions.Include(transaction => transaction.TransactionLines).ToList();
            
        }

        public Transaction? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Transactions.Where(transaction => transaction.Id == id).Include(transaction => transaction.TransactionLines).SingleOrDefault();
        }

        public void Update(int id, Transaction entity) {
            using var context = new CarServiceCenterDbContext();
            var TransactionDb = context.Transactions.Where(transaction => transaction.Id == id).Include(transaction => transaction.TransactionLines).SingleOrDefault();
            if (TransactionDb is null)
                return;
            TransactionDb.Date = entity.Date;
            TransactionDb.CustomerId = entity.CustomerId;
            TransactionDb.CarId = entity.CarId;
            TransactionDb.ManagerId = entity.ManagerId;
            TransactionDb.TotalPrice = entity.TotalPrice;
            context.SaveChanges();
        }
    }
}
