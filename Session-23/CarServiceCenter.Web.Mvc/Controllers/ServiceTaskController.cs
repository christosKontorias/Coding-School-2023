using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
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
            return View();
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
            return View();
        }

        // POST: ServiceTaskController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: ServiceTaskController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: ServiceTaskController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }
    }
}
