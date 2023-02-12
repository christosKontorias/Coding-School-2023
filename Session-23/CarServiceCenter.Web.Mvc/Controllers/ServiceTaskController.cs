using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Mvc.Models.Customer;
using CarServiceCenter.Web.Mvc.Models.ServiceTask;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class ServiceTaskController : Controller {

        private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;

        public ServiceTaskController(IEntityRepo<ServiceTask> serviceTaskRepo) {
            _serviceTaskRepo = serviceTaskRepo;
        }
        // GET: ServiceTaskController
        public ActionResult ServiceTask() {
            var serviceTasks = _serviceTaskRepo.GetAll();
            return View(model: serviceTasks);
        }

        // GET: ServiceTaskController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }
            var serviceTasks = _serviceTaskRepo.GetById(id);
            if (serviceTasks == null) {
                return NotFound();
            }

            var viewServiceTask = new ServiceTaskDetailsDto();
            viewServiceTask.Id = serviceTasks.Id;
            viewServiceTask.Code = serviceTasks.Code;
            viewServiceTask.Description = serviceTasks.Description;
            viewServiceTask.Hours = serviceTasks.Hours;

            //viewServiceTask.TransactionLines = serviceTasks.TransactionLines.ToList();
            return View(model: viewServiceTask);
        }

        // GET: ServiceTaskController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ServiceTaskController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ServiceTaskCreateDto serviceTask) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }
                var ServiceTaskDb = new ServiceTask();
                ServiceTaskDb.Code = serviceTask.Code;
                ServiceTaskDb.Description = serviceTask.Description;
                ServiceTaskDb.Hours = serviceTask.Hours;
                _serviceTaskRepo.Add(ServiceTaskDb);

                return RedirectToAction("ServiceTask");
            } catch {
                return View();
            }
        }

        // GET: ServiceTaskController/Edit/5
        public ActionResult Edit(int id) {
            var ServiceTaskDb = _serviceTaskRepo.GetById(id);
            if (ServiceTaskDb == null) {
                return null;
            }

            var viewServiceTask = new ServiceTaskEditDto();
            viewServiceTask.Code = ServiceTaskDb.Code;
            viewServiceTask.Description = ServiceTaskDb.Description;
            viewServiceTask.Hours = ServiceTaskDb.Hours;
            return View(model: viewServiceTask);
        }

        // POST: ServiceTaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ServiceTaskEditDto serviceTask) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }
                var ServiceTaskDb = _serviceTaskRepo.GetById(id);

                if (ServiceTaskDb == null) {
                    return NotFound();
                }

                ServiceTaskDb.Code = serviceTask.Code;
                ServiceTaskDb.Description = serviceTask.Description;
                ServiceTaskDb.Hours = serviceTask.Hours;
                _serviceTaskRepo.Update(id, ServiceTaskDb);
                return RedirectToAction(nameof(ServiceTask));
            } catch {
                return View();
            }
        }

        // GET: ServiceTaskController/Delete/5
        public ActionResult Delete(int id) {
            var ServiceTaskDb = _serviceTaskRepo.GetById(id);
            if (ServiceTaskDb == null) {
                return NotFound();
            }

            var viewServiceTask = new ServiceTaskDeleteDto {
                Code = ServiceTaskDb.Code,
                Description = ServiceTaskDb.Description,
                Hours = ServiceTaskDb.Hours,
            };

            return View(model: viewServiceTask);
        }

        // POST: ServiceTaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _serviceTaskRepo.Delete(id);
                return RedirectToAction(nameof(ServiceTask));
            } catch {
                return View();
            }
        }
    }
}
