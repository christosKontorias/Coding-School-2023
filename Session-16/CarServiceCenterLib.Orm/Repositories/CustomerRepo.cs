using CarServiceCenterLib.Models;
using CarServiceCenterLib.Orm.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenterLib.Orm.Repositories {
    public class CustomerRepo : IEntityRepo<Customer> {
        public void Add(Customer entity) {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var CustomerDb  = context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
            if (CustomerDb is null)
                return;
            context.Remove(CustomerDb);
            context.SaveChanges();
        }

        public IList<Customer> GetAll() {
            using var context = new AppDbContext();
            return context.Customers
                .Include(customer => customer.ID)
                .Include(customer => customer.Name)
                .Include(customer => customer.Surname)
                .Include(customer => customer.Phone)
                .Include(customer => customer.TIN)
                .ToList();

        }

        public Customer? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Customers.Where(customer => customer.ID == id)
                .Include(customer => customer.ID)
                .Include(customer => customer.Name)
                .Include(customer => customer.Surname)
                .Include(customer => customer.Phone)
                .Include(customer => customer.TIN)
                .SingleOrDefault();
        }

        public void Update(Guid id, Customer entity) {
            using var context = new AppDbContext();
            var CustomerDb = context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
            if (CustomerDb is null)
                return;
            CustomerDb.Name = entity.Name;
            CustomerDb.Surname = entity.Surname;
            CustomerDb.Phone = entity.Phone;
            CustomerDb.TIN = entity.TIN;
            context.SaveChanges();
        }
    }
}
