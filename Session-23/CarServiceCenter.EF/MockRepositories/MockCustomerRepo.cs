using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.MockRepositories {
    public class MockCustomerRepo : IEntityRepo<Customer> {

        private readonly List<Customer> _customers;
        public MockCustomerRepo() {
            _customers = new List<Customer>()
            {
                new Customer{ Id = 1, Name = "Christos", Surname = "Kontorias", Phone="6912345678", Tin="123456789"},
                new Customer{ Id = 2, Name = "UserFirstName", Surname = "UserLastName", Phone="6987654321", Tin="987654321"},
            };
        }
        public void Add(Customer entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAll() {
            return _customers;
        }

        public Customer? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(int id, Customer entity) {
            throw new NotImplementedException();
        }
    }
}
