﻿using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class ManagerRepo : IEntityRepo<Manager> {
        public void Add(Manager entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var ManagerDb = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (ManagerDb is null)
                return;
            context.Remove(ManagerDb);
            context.SaveChanges();
        }

        public IList<Manager> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Managers.ToList();
        }

        public Manager? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Managers.SingleOrDefault();
        }

        public void Update(int id, Manager entity) {
            using var context = new CarServiceCenterDbContext();
            var ManagerDb = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (ManagerDb is null)
                return;
            ManagerDb.Name = entity.Name;
            ManagerDb.Surname = entity.Surname;
            ManagerDb.SalaryPerMonth = entity.SalaryPerMonth;

            context.SaveChanges();
        }
    }
}