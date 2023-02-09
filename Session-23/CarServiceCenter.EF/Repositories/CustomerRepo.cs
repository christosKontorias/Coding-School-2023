using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {
        public void Add(Customer entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var CustomerDb = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (CustomerDb is null)
                return;
            context.Remove(CustomerDb);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Customers.ToList();
        }

        public Customer? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Customers.SingleOrDefault();
        }

        public void Update(int id, Customer entity) {
            using var context = new CarServiceCenterDbContext();
            var CustomerDb = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (CustomerDb is null)
                return;
            CustomerDb.Name = entity.Name;
            CustomerDb.Surname = entity.Surname;
            CustomerDb.Phone = entity.Phone;
            CustomerDb.Tin = entity.Tin;
            context.SaveChanges();
        }
    }
}
