using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Mvc.Models.Engineer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenter.Web.Mvc.Controllers {
	public class EngineerController : Controller {

		private readonly IEntityRepo<Engineer> _engineerRepo;
		private readonly IEntityRepo<Manager> _managerRepo;

		public EngineerController(IEntityRepo<Manager> managerRepo, IEntityRepo<Engineer> engineerRepo) {
			_managerRepo = managerRepo;
			_engineerRepo = engineerRepo;
		}

		//public EngineerController(IEntityRepo<Engineer> engineerRepo) {
		//    _engineerRepo = engineerRepo;
		//}
		// GET: EngineerController
		public ActionResult Engineer() {
			var engineers = _engineerRepo.GetAll();
			return View(model: engineers);
		}

		// GET: EngineerController/Details/5
		public ActionResult Details(int id) {
			return View();
		}

		// GET: EngineerController/Create
		public ActionResult Create() {
			var newEngineer = new EngineerCreateDto();
			var managers = _managerRepo.GetAll();
			foreach (var manager in managers) {
				newEngineer.Managers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(manager.Surname, manager.Id.ToString()));
			}
			return View(model: newEngineer);
		}

		// POST: EngineerController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(EngineerCreateDto engineer) {
			try {
				if (!ModelState.IsValid) {
					return View();
				}
				var EngineerDb = new Engineer();
				EngineerDb.Name = engineer.Name;
				EngineerDb.Surname = engineer.Surname;
				EngineerDb.SalaryPerMonth = engineer.SalaryPerMonth;
				EngineerDb.ManagerId = engineer.ManagerId;

				_engineerRepo.Add(EngineerDb);

				return RedirectToAction("Engineer");
			} catch {
				return View();
			}
		}

		// GET: EngineerController/Edit/5
		public ActionResult Edit(int id) {
			var EngineerDb = _engineerRepo.GetById(id);
			if (EngineerDb == null) {
				return null;
			}

			var viewEngineer = new EngineerEditDto();
			viewEngineer.Name = EngineerDb.Name;
			viewEngineer.Surname = EngineerDb.Surname;
			viewEngineer.SalaryPerMonth = EngineerDb.SalaryPerMonth;
			viewEngineer.ManagerId = EngineerDb.ManagerId;

			// Get the list of managers
			var managers = _managerRepo.GetAll();
			ViewBag.ManagerId = new SelectList(managers, "Id", "Surname", viewEngineer.ManagerId);

			return View(model: viewEngineer);

		}

		// POST: EngineerController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, EngineerEditDto engineer) {
			try {
				if (!ModelState.IsValid) {
					return View();
				}
				var EngineerDb = _engineerRepo.GetById(id);

				if (EngineerDb == null) {
					return NotFound();
				}

				EngineerDb.Name = engineer.Name;
				EngineerDb.Surname = engineer.Surname;
				EngineerDb.SalaryPerMonth = engineer.SalaryPerMonth;
				EngineerDb.ManagerId = engineer.ManagerId;

				_engineerRepo.Update(id, EngineerDb);
				return RedirectToAction(nameof(Engineer));
			} catch (Exception ex) {

				return View();
			}
		}

		// GET: EngineerController/Delete/5
		public ActionResult Delete(int id) {
			var EngineerDb = _engineerRepo.GetById(id);
			if (EngineerDb == null) {
				return NotFound();
			}

			var viewEngineer = new EngineerDeleteDto {
				Name = EngineerDb.Name,
				Surname = EngineerDb.Surname,
				SalaryPerMonth = EngineerDb.SalaryPerMonth
			};

			return View(model: viewEngineer);
		}

		// POST: EngineerController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection) {
			try {
				_engineerRepo.Delete(id);
				return RedirectToAction(nameof(Engineer));
			} catch {
				return View();
			}
		}
	}
}
