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
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Car> _carRepo;

        public MockTransactionRepo(IEntityRepo<Customer> customerRepo, IEntityRepo<Manager> managerRepo,IEntityRepo<Car> carRepo) {
            _transactions = new List<Transaction>()
            {
                new Transaction{ Id = 1, CustomerId = 1, ManagerId = 1, CarId = 1},            
            };

            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _carRepo = carRepo;

        }
        public void Add(Transaction entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Transaction> GetAll() {
            var customers = _customerRepo.GetAll();
            var managers = _managerRepo.GetAll();
            var cars = _carRepo.GetAll();

            foreach (var transaction in _transactions) {
                transaction.Customer = customers.FirstOrDefault(customer => customer.Id == customer.Id);
                transaction.Manager = managers.FirstOrDefault(manager => manager.Id == manager.Id);
                transaction.Car = cars.FirstOrDefault(car => car.Id == car.Id);
            }
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
