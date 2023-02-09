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
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            using var context = new CarServiceCenterDbContext();
            var ServiceTaskDb = context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();
            if (ServiceTaskDb is null)
                return;
            context.Remove(ServiceTaskDb);
            context.SaveChanges();
        }

        public IList<ServiceTask> GetAll() {
            using var context = new CarServiceCenterDbContext();
            return context.ServiceTasks.ToList();
        }

        public ServiceTask? GetById(int id) {
            using var context = new CarServiceCenterDbContext();
            return context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();
        }

        public void Update(int id, ServiceTask entity) {
            using var context = new CarServiceCenterDbContext();
            var ServiceTaskDb = context.ServiceTasks.Where(serviceTask => serviceTask.Id == id).SingleOrDefault();
            if (ServiceTaskDb is null)
                return;
            ServiceTaskDb.Code = entity.Code;
            ServiceTaskDb.Description = entity.Description;
            ServiceTaskDb.Hours = entity.Hours;
            context.SaveChanges();
        }
    }
}
