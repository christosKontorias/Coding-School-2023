using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class CustomerController : Controller {

        private readonly IEntityRepo<Customer> _customerRepo;
        public CustomerController(IEntityRepo<Customer> customerRepo) {
            _customerRepo = customerRepo;
        }

        // GET: CustomerController
        public ActionResult Customer() {
            var customers = _customerRepo.GetAll();
            return View(model: customers);
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CustomerCreateDto customer) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }
                var CustomerDb = new Customer();
                CustomerDb.Name = customer.Name;
                CustomerDb.Surname = customer.Surname;
                CustomerDb.Phone = customer.Phone;
                CustomerDb.Tin = customer.Tin;
                _customerRepo.Add(CustomerDb);

                return RedirectToAction("Customer");
            } catch {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id) {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection) {
            try {
                return RedirectToAction(nameof(Index));
            } catch {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id) {
            return View();
        }

        // POST: CustomerController/Delete/5
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
