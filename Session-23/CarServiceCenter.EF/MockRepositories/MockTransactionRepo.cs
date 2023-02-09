using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.MockRepositories {
    public class MockTransactionRepo : IEntityRepo<Transaction> {

        private readonly List<Transaction> _transactions;
        public MockTransactionRepo() {
            _transactions = new List<Transaction>()
            {
                new Transaction{ Id = 1},            
            };
        }
        public void Add(Transaction entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Transaction> GetAll() {
            return _transactions;
        }

        public Transaction? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(int id, Transaction entity) {
            throw new NotImplementedException();
        }
    }
}
