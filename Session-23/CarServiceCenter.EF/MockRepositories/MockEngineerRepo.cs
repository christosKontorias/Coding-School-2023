using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.MockRepositories {
    public class MockEngineerRepo : IEntityRepo<Engineer> {

        private readonly List<Engineer> _engineers;
        private readonly IEntityRepo<Manager> _managerRepo;


        public MockEngineerRepo(IEntityRepo<Manager> managerRepo) {
            _engineers = new List<Engineer>()
            {
                new Engineer {Id = 1, Name = "EngineerName", Surname = "EngineerSurname", SalaryPerMonth =  1200, ManagerId = 1},
                new Engineer {Id = 2, Name = "EngineerName2", Surname = "EngineerSurnam2", SalaryPerMonth =  1050, ManagerId = 2},
            };
            _managerRepo = managerRepo;

        }
        public void Add(Engineer entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Engineer> GetAll() {
            var managers = _managerRepo.GetAll();

            foreach (var engineer in _engineers) {
                engineer.Manager = managers.FirstOrDefault(m => m.Id == engineer.ManagerId);
            }

            return _engineers;
        }

        public Engineer? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(int id, Engineer entity) {
            throw new NotImplementedException();
        }
    }
}
