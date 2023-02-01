using CarServiceCenterLib.Models;
using CarServiceCenterLib.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLib.Orm.Repositories {
    public class TransactionRepo : IEntityRepo<Transaction> {
        public void Add(Transaction entity) {
            using var context = new AppDbContext();
            if (!EntityExist(entity)) {
                context.Add(entity);
                context.SaveChanges();
            }
        }
        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var TransactionDb = context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
            if (TransactionDb is null)
                return;
            context.Remove(TransactionDb);
            context.SaveChanges();
        }
        public IList<Transaction> GetAll() {
            using var context = new AppDbContext();
            return context.Transactions.ToList();

        }
        public Transaction? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Transactions.SingleOrDefault();
        }
        public void Update(Guid id, Transaction entity) {
            using var context = new AppDbContext();
            var TransactionDb = context.Transactions.Where(transaction => transaction.ID == id).SingleOrDefault();
            if (TransactionDb is null)
                return;
            TransactionDb.TransactionLines = entity.TransactionLines;
            TransactionDb.Customer = entity.Customer;
            TransactionDb.Car = entity.Car;
            TransactionDb.Manager = entity.Manager;

            context.SaveChanges();
        }
        public bool EntityExist(Transaction entity) {
            using var context = new AppDbContext();
            var TransactionDb = context.Transactions
                .Where(Transaction => Transaction.ID == entity.ID
            && Transaction.Date == entity.Date
            && Transaction.CustomerID == entity.CustomerID
            && Transaction.CarID == entity.CarID
            && Transaction.ManagerID == entity.ManagerID
            && Transaction.TotalPrice == entity.TotalPrice
            ).SingleOrDefault();
            if (TransactionDb is null) {
                var Transaction1Db = context.Transactions
                .Where(transaction => transaction.ID == entity.ID).SingleOrDefault();
                if (Transaction1Db is null) { return false; } else {
                    return true;
                }
            } else return true;
        }
    }
}
