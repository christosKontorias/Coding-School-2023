﻿using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class CarRepo : IEntityRepo<Car> {
        public void Add(Car entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Car> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Cars.ToList();
        }

        public Car? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(int id, Car entity) {
            throw new NotImplementedException();
        }
    }
}
