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
            using var context = new CarServiceCenterDbContext();
            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.Cars.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var CarDb = context.Cars.Where(car => car.Id == id).SingleOrDefault();

            if (CarDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            context.Cars.Remove(CarDb);
            context.SaveChanges();
        }

        public IList<Car> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.Cars.ToList();
        }

        public Car? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            var CarDb = context.Cars.Where(car => car.Id == id).SingleOrDefault();

            if (CarDb is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return CarDb;
            }
        }

        public void Update(int id, Car entity) {
            using var context = new CarServiceCenterDbContext();
            var CarDb = context.Cars.Where(car => car.Id == id).SingleOrDefault();
            if (CarDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            CarDb.Brand = entity.Brand;
            CarDb.Model = entity.Model;
            CarDb.CarRegistrationNumber = entity.CarRegistrationNumber;
            context.SaveChanges();
        }
    }
}
