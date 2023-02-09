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
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var TransactionLineDb = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (TransactionLineDb is null)
                return;
            context.Remove(TransactionLineDb);
            context.SaveChanges();
        }

        public IList<TransactionLine> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.Include(transactionLine => transactionLine.Transaction).ToList();
        }

        public TransactionLine? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity) {
            using var context = new CarServiceCenterDbContext();
            var TransactionLineDb = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (TransactionLineDb is null)
                return;
            TransactionLineDb.Price = entity.Price;
            TransactionLineDb.PricePerHour = entity.PricePerHour;
            TransactionLineDb.Hours = entity.Hours;
            TransactionLineDb.ServiceTaskId = entity.ServiceTaskId;

            context.SaveChanges();
        }
    }
}
