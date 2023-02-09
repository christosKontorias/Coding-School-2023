﻿using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class EngineerRepo : IEntityRepo<Engineer> {
        public void Add(Engineer entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var EngineerDb = context.Engineers.Where(engineer => engineer.Id == id).SingleOrDefault();
            if (EngineerDb is null)
                return;
            context.Remove(EngineerDb);
            context.SaveChanges();
        }

        public IList<Engineer> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Engineers.ToList();
        }

        public Engineer? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Engineers.Where(engineer => engineer.Id == id).SingleOrDefault();
        }

        public void Update(int id, Engineer entity) {
            using var context = new CarServiceCenterDbContext();
            var EngineerDb = context.Engineers
                .Where(engineer => engineer.Id == id)
                .SingleOrDefault();
            if (EngineerDb is null) return;
            EngineerDb.Name = entity.Name;
            EngineerDb.Surname = entity.Surname;
            EngineerDb.ManagerId = entity.ManagerId;
            EngineerDb.SalaryPerMonth = entity.SalaryPerMonth;
            context.SaveChanges();
        }
    }
}
