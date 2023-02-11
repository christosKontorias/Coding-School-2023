using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Mvc.Models.Transaction;
using CarServiceCenter.Web.Mvc.Models.TransactionLine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class TransactionController : Controller {

        private readonly IEntityRepo<Transaction> _transactionRepo;
        private readonly IEntityRepo<Customer> _customerRepo;
        private readonly IEntityRepo<Manager> _managerRepo;
        private readonly IEntityRepo<Car> _carRepo;


        public TransactionController(IEntityRepo<Transaction> transactionRepo,
                                     IEntityRepo<Customer> customerRepo,
                                     IEntityRepo<Manager> managerRepo,
                                     IEntityRepo<Car> carRepo) {
            _transactionRepo = transactionRepo;
            _customerRepo = customerRepo;
            _managerRepo = managerRepo;
            _carRepo = carRepo;
        }

        // GET: TransactionController
        public ActionResult Transaction() {
            var transactions = _transactionRepo.GetAll();
            return View(model: transactions);

        }

        // GET: TransactionController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: TransactionController/Create
        public ActionResult Create() {
            var newTransaction = new TransactionCreateDto();
            var customers = _customerRepo.GetAll();
            foreach (var customer in customers) {
                newTransaction.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(customer.Surname, customer.Id.ToString()));
            }

            var managers = _managerRepo.GetAll();
            foreach (var manager in managers) {
                newTransaction.Managers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(manager.Surname, manager.Id.ToString()));
            }

            var cars = _carRepo.GetAll();
            foreach (var car in cars) {
                newTransaction.Cars.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(car.Model, car.Id.ToString()));
            }

            return View(model: newTransaction);
        }

        // POST: TransactionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TransactionCreateDto transaction) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }
                var TransactionDb = new Transaction();
                TransactionDb.Date = transaction.Date;

                _transactionRepo.Add(TransactionDb);

                return RedirectToAction("Transaction");
            } catch {
                return View();
            }
        }

        // GET: TransactionController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: TransactionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: TransactionController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: TransactionController/Delete/5
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
