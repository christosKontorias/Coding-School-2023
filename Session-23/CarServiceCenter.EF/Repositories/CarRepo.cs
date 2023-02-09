using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;
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
            using var context = new CarServiceCenterDbContext();
            var CarDb = context.Cars.Where(car => car.Id == id).SingleOrDefault();
            if (CarDb is null)
                return;
            context.Remove(CarDb);
            context.SaveChanges();
        }

        public IList<Car> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Cars.ToList();
        }

        public Car? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.Cars.SingleOrDefault();
        }

        public void Update(int id, Car entity) {
            using var context = new CarServiceCenterDbContext();
            var CarDb = context.Cars.Where(car => car.Id == id).SingleOrDefault();
            if (CarDb is null)
                return;
            CarDb.Brand = entity.Brand;
            CarDb.Model = entity.Model;
            CarDb.CarRegistrationNumber = entity.CarRegistrationNumber;
            context.SaveChanges();
        }
    }
}
