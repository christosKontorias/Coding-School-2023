using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class ServiceTaskRepo : IEntityRepo<ServiceTask> {
        public void Add(ServiceTask entity) {
            using var context = new CarServiceCenterDbContext();
            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));

            context.ServiceTasks.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var ServiceTaskDb = context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();
            if (ServiceTaskDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            context.Remove(ServiceTaskDb);
            context.SaveChanges();
        }

        public IList<ServiceTask> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.ServiceTasks.ToList();
        }

        public ServiceTask? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            var ServiceTaskDb = context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();

            if (ServiceTaskDb is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            } else {
                return ServiceTaskDb;
            }
        }

        public void Update(int id, ServiceTask entity) {
            using var context = new CarServiceCenterDbContext();
            var ServiceTaskDb = context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();
            if (ServiceTaskDb is null)
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            ServiceTaskDb.Code = entity.Code;
            ServiceTaskDb.Description = entity.Description;
            ServiceTaskDb.Hours = entity.Hours;
            context.SaveChanges();
        }
    }
}
