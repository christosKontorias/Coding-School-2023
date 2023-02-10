using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.MockRepositories {
    public class MockTransactionLineRepo : IEntityRepo<TransactionLine> {

        private readonly List<TransactionLine> _transactionLines;
        public MockTransactionLineRepo() {
            _transactionLines = new List<TransactionLine>()
            {
                 new TransactionLine{ Id = 1, Hours = 4, PricePerHour = 30, Price = 120 },
            };
        }

        public void Add(TransactionLine entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<TransactionLine> GetAll() {
            return _transactionLines;

        }

        public TransactionLine? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(int id, TransactionLine entity) {
            throw new NotImplementedException();
        }
    }
}
