using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.MockRepositories {
    public class MockServiceTaskRepo : IEntityRepo<ServiceTask> {

        private readonly List<ServiceTask> _serviceTasks;
        public MockServiceTaskRepo() {
            _serviceTasks = new List<ServiceTask>()
            {
                new ServiceTask { Id = 1, Code = "001", Description = "Air Filter", Hours = 1 },
                new ServiceTask { Id = 2, Code = "002", Description = "Oil Filter", Hours = 3 },
                new ServiceTask { Id = 3, Code = "003", Description = "Spark plug", Hours = 3 },
                new ServiceTask { Id = 4, Code = "004", Description = "Cabin Filter", Hours = 2 },
                new ServiceTask { Id = 5, Code = "005", Description = "Change gasket", Hours = 4 },
                new ServiceTask { Id = 6, Code = "006", Description = "General service", Hours = 5 },

            };
        }
        public void Add(ServiceTask entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<ServiceTask> GetAll() {
            return _serviceTasks;
        }

        public ServiceTask? GetById(int id) {
            throw new NotImplementedException();
        }

        public void Update(int id, ServiceTask entity) {
            throw new NotImplementedException();
        }
    }
}
