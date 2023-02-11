using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {
        public void Add(Customer entity) {
            using var context = new CarServiceCenterDbContext();

            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Customers.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var CustomerDb = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (CustomerDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            context.Remove(CustomerDb);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Customers.Include(customer => customer.Transactions).ToList();
        }

        public Customer? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            var CustomerDb = context.Customers.Include(customer => customer.Transactions).Where(customer => customer.Id == id).SingleOrDefault();
            if (CustomerDb is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return CustomerDb;
            }
        }

        public void Update(int id, Customer entity) {
            using var context = new CarServiceCenterDbContext();
            var CustomerDb = context.Customers.Where(customer => customer.Id == id).SingleOrDefault();
            if (CustomerDb is null) 
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            
            CustomerDb.Name = entity.Name;
            CustomerDb.Surname = entity.Surname;
            CustomerDb.Phone = entity.Phone;
            CustomerDb.Tin = entity.Tin;

            context.SaveChanges();
        }
    }
}
