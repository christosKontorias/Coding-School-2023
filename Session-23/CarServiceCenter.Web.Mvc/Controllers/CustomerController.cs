using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Mvc.Models.Car;
using CarServiceCenter.Web.Mvc.Models.Customer;
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
            if (id == null) {
                return NotFound();
            }

            var customer = _customerRepo.GetById(id);
            if (customer == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerDetailsDto();
            viewCustomer.Id = customer.Id;
            viewCustomer.Name = customer.Name;
            viewCustomer.Surname = customer.Surname;
            viewCustomer.Phone = customer.Phone;
            viewCustomer.Tin = customer.Tin;
            //viewCar.Transactions = car.Transactions.ToList();
            return View(model: viewCustomer);
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
            var CustomerDb = _customerRepo.GetById(id);
            if (CustomerDb == null) {
                return null;
            }

            var viewCustomer = new CustomerEditDto();
            viewCustomer.Name = CustomerDb.Name;
            viewCustomer.Surname = CustomerDb.Surname;
            viewCustomer.Phone = CustomerDb.Phone;
            viewCustomer.Tin = CustomerDb.Tin;
            return View(model: viewCustomer);
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CustomerEditDto customer) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }
                var CustomerDb = _customerRepo.GetById(id);

                if (CustomerDb == null) {
                    return NotFound();
                }

                CustomerDb.Name = customer.Name;
                CustomerDb.Surname = customer.Surname;
                CustomerDb.Phone = customer.Phone;
                CustomerDb.Tin = customer.Tin;
                _customerRepo.Update(id, CustomerDb);
                return RedirectToAction(nameof(Customer));
            } catch {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id) {
            var CustomerDb = _customerRepo.GetById(id);
            if (CustomerDb == null) {
                return NotFound();
            }

            var viewCustomer = new CustomerDeleteDto {
                Name = CustomerDb.Name,
                Surname = CustomerDb.Surname,
                Phone = CustomerDb.Phone,
                Tin = CustomerDb.Tin
            };

            return View(model: viewCustomer);
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {
                _customerRepo.Delete(id);
                return RedirectToAction(nameof(Customer));
            } catch {
                return View();
            }
        }
    }
}
