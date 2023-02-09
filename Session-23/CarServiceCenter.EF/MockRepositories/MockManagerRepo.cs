using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.MockRepositories {
    public class MockManagerRepo : IEntityRepo<Manager> {

        private readonly List<Manager> _managers;
        public MockManagerRepo() {
            _managers = new List<Manager>()
            {
                new Manager {Id = 1, Name = "ManagerName", Surname = "ManagerSurname", SalaryPerMonth =  2000 },
                new Manager {Id = 2, Name = "ManagerName2", Surname = "ManagerSurname2", SalaryPerMonth =  2500 },
                new Manager {Id = 3, Name = "ManagerName3", Surname = "ManagerSurname3", SalaryPerMonth =  1900 },

            };
        }
        public void Add(Manager entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Manager> GetAll() {
            return _managers;
        }

        public Manager? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(int id, Manager entity) {
            throw new NotImplementedException();
        }
    }
}
