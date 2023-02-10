using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class ManagerController : Controller {

        private readonly IEntityRepo<Manager> _managerRepo;

        public ManagerController(IEntityRepo<Manager> managerRepo) {
            _managerRepo = managerRepo;
        }
        // GET: ManagerController
        public ActionResult Manager() {
            var managers = _managerRepo.GetAll();
            return View(model: managers);
        }

        // GET: ManagerController/Details/5
        public ActionResult Details(int id) {
            if (id == null) {
                return NotFound();
            }

            var manager = _managerRepo.GetById(id);
            if (manager == null) {
                return NotFound();
            }

            var viewManager = new ManagerDetailsDto();
            viewManager.Id = manager.Id;
            viewManager.Name = manager.Name;
            viewManager.Surname = manager.Surname;
            viewManager.SalaryPerMonth = manager.SalaryPerMonth;
            //viewManager.Engineers = manager.Engineers.ToList();
            //viewManager.Transactions = car.Transactions.ToList();
            return View(model: viewManager);
        }

        // GET: ManagerController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: ManagerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ManagerCreateDto manager) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }
                var ManagerDb = new Manager();
                ManagerDb.Name = manager.Name;
                ManagerDb.Surname = manager.Surname;
                ManagerDb.SalaryPerMonth = manager.SalaryPerMonth;
                _managerRepo.Add(ManagerDb);

                return RedirectToAction("Manager");
            } catch {
                return View();
            }
        }

        // GET: ManagerController/Edit/5
        public ActionResult Edit(int id) {
            var ManagerDb = _managerRepo.GetById(id);
            if (ManagerDb == null) {
                return null;
            }

            var viewManager = new ManagerEditDto();
            viewManager.Name = ManagerDb.Name;
            viewManager.Surname = ManagerDb.Surname;
            viewManager.SalaryPerMonth = ManagerDb.SalaryPerMonth;
            return View(model: viewManager);
        }

        // POST: ManagerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ManagerEditDto manager) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }
                var ManagerDb = _managerRepo.GetById(id);

                if (ManagerDb == null) {
                    return NotFound();
                }

                ManagerDb.Name = manager.Name;
                ManagerDb.Surname = manager.Surname;
                ManagerDb.SalaryPerMonth = manager.SalaryPerMonth;
                _managerRepo.Update(id, ManagerDb);
                return RedirectToAction(nameof(Manager));
            } catch {
                return View();
            }
        }

        // GET: ManagerController/Delete/5
        public ActionResult Delete(int id) {
            var ManagerDb = _managerRepo.GetById(id);
            if (ManagerDb == null) {
                return NotFound();
            }

            var viewManager = new ManagerDeleteDto {
                Name = ManagerDb.Name,
                Surname = ManagerDb.Surname,
                SalaryPerMonth = ManagerDb.SalaryPerMonth
            };

            return View(model: viewManager);
        }

        // POST: ManagerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _managerRepo.Delete(id);
                return RedirectToAction(nameof(Manager));
            } catch {
                return View();
            }
        }
    }
}
