using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class MockCarRepo : IEntityRepo<Car> {

        private readonly List<Car> _cars;
        public MockCarRepo() {
            _cars = new List<Car>()
            {
                new Car { Id = 1, Brand = "Volvo", Model="C40", CarRegistrationNumber = "XXX-0001"},
                new Car { Id = 2, Brand = "Tesla", Model="Model Y", CarRegistrationNumber = "XXX-0002"},
            };
        }    
        public void Add(Car entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Car> GetAll() {
            return _cars;
        }

        public Car? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(int id, Car entity) {
            throw new NotImplementedException();
        }
    }
}
