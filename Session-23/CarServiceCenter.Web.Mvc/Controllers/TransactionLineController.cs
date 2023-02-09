using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class TransactionLineController : Controller {

        private readonly IEntityRepo<TransactionLine> _transactionLineRepo;

        public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo) {
            _transactionLineRepo = transactionLineRepo;
        }


        // GET: TransactionLineController
        public ActionResult TransactionLine() {
            var transactionLines = _transactionLineRepo.GetAll();
            return View(model: transactionLines);
        }

        // GET: TransactionLineController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: TransactionLineController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: TransactionLineController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: TransactionLineController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: TransactionLineController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: TransactionLineController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: TransactionLineController/Delete/5
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
