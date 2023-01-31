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
            if (!EntityExist(entity)) {
                context.Add(entity);
                context.SaveChanges();
            }
        }
        public void Delete(Guid id) {
            using var context = new AppDbContext();
            var CustomerDb = context.Customers.Where(customer => customer.ID == id).SingleOrDefault();
            if (CustomerDb is null)
                return;
            context.Remove(CustomerDb);
            context.SaveChanges();
        }
        public IList<Customer> GetAll() {
            using var context = new AppDbContext();
            return context.Customers.ToList();
        }
        public Customer? GetById(Guid id) {
            using var context = new AppDbContext();
            return context.Customers.SingleOrDefault();
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
        public bool EntityExist(Customer entity) {
            using var context = new AppDbContext();
            var CustomerDb = context.Customers
                .Where(customer => customer.Name == entity.Name
            && customer.Surname == entity.Surname
            && customer.Phone == entity.Phone
            && customer.TIN == entity.TIN
            ).SingleOrDefault();
            if (CustomerDb is null) {
                var Customer1Db = context.Customers
                .Where(customer => customer.ID == entity.ID).SingleOrDefault(); ;
                if (Customer1Db is null) { return false; } else {
                    return true;
                }
            } else return true;
        }
    }
}