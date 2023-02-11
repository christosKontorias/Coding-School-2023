using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {
        public void Add(TransactionLine entity) {
            using var context = new CarServiceCenterDbContext();

            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.TransactionLines.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var TransactionLineDb = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (TransactionLineDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            context.Remove(TransactionLineDb);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.ToList();
        }

        public TransactionLine? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            var TransactionLineDb = context.TransactionLines.Include(transaction => transaction.Id).Include(serviceTask => serviceTask.Id).Include(engineer => engineer.Id).Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (TransactionLineDb is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return TransactionLineDb;
            }
        }

        public void Update(int id, TransactionLine entity) {
            using var context = new CarServiceCenterDbContext();
            var TransactionLineDb = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (TransactionLineDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            TransactionLineDb.Price = entity.Price;
            TransactionLineDb.PricePerHour = entity.PricePerHour;
            TransactionLineDb.Hours = entity.Hours;
            TransactionLineDb.ServiceTaskId = entity.ServiceTaskId;

            context.SaveChanges();
        }
    }
}
