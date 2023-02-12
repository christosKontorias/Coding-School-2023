using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Mvc.Models.Engineer;
using CarServiceCenter.Web.Mvc.Models.Transaction;
using CarServiceCenter.Web.Mvc.Models.TransactionLine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CarServiceCenter.Web.Mvc.Controllers; 

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
        return View(transactions);
    }


    // GET: TransactionController/Details/5
    public ActionResult Details(int id) {
		if (id == null) {
			return NotFound();
		}

		var transaction = _transactionRepo.GetById(id);
		if (transaction == null) {
			return NotFound();
		}

		var viewTransaction = new TransactionDetailsDto();
		viewTransaction.Date = transaction.Date;
		viewTransaction.TotalPrice = transaction.TotalPrice;
		viewTransaction.CustomerId = transaction.CustomerId;
		viewTransaction.ManagerId = transaction.ManagerId;
		viewTransaction.CarId = transaction.CarId;

		return View(model: viewTransaction);
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
            //TransactionDb.TotalPrice = transaction.TotalPrice;
            TransactionDb.CustomerId = transaction.CustomerId;
            TransactionDb.ManagerId = transaction.ManagerId;
            TransactionDb.CarId = transaction.CarId;
            
            _transactionRepo.Add(TransactionDb);

            return RedirectToAction("Transaction");
        } catch {
            return View();
        }
    }

    // GET: TransactionController/Edit/5
    public ActionResult Edit(int id) {
        var TransactionDb = _transactionRepo.GetById(id);
        if (TransactionDb == null) {
            return null;
        }

        var viewTransaction = new TransactionEditDto();
        viewTransaction.Date = TransactionDb.Date;
        viewTransaction.TotalPrice = TransactionDb.TotalPrice;
        viewTransaction.CustomerId = TransactionDb.CustomerId;
        viewTransaction.ManagerId = TransactionDb.ManagerId;
        viewTransaction.CarId = TransactionDb.CarId;


        // Get the list of customers
        var customers = _customerRepo.GetAll();
        ViewBag.CustomerId = new SelectList(customers, "Id", "Surname", viewTransaction.CustomerId);

        // Get the list of managers
        var managers = _managerRepo.GetAll();
        ViewBag.ManagerId = new SelectList(managers, "Id", "Surname", viewTransaction.ManagerId);

        // Get the list of managers
        var cars = _carRepo.GetAll();
        ViewBag.CarId = new SelectList(cars, "Id", "Model", viewTransaction.CarId);

        return View(model: viewTransaction);
    }

    // POST: TransactionController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, TransactionEditDto transaction) {
        try {
            if (!ModelState.IsValid) {
                return View();
            }
            var TransactionDb = _transactionRepo.GetById(id);

            if (TransactionDb == null) {
                return NotFound();
            }

            TransactionDb.Date = transaction.Date;
            TransactionDb.TotalPrice = transaction.TotalPrice;
            TransactionDb.CustomerId = transaction.CustomerId;
            TransactionDb.ManagerId = transaction.ManagerId;
            TransactionDb.CarId = transaction.CarId;


            _transactionRepo.Update(id, TransactionDb);
            return RedirectToAction(nameof(Transaction));
        } catch (Exception ex) {

            return View();
        }
    }

    // GET: TransactionController/Delete/5
    public ActionResult Delete(int id) {
        var TransactionDb = _transactionRepo.GetById(id);
        if (TransactionDb == null) {
            return NotFound();
        }

        var viewTransaction = new TransactionDeleteDto {
            Date = TransactionDb.Date,
            TotalPrice = TransactionDb.TotalPrice,
            CustomerId = TransactionDb.CustomerId,
            ManagerId = TransactionDb.ManagerId,
            CarId = TransactionDb.CarId
        };

        return View(model: viewTransaction);
    }

    // POST: TransactionController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection) {
        try {
            _transactionRepo.Delete(id);
            return RedirectToAction(nameof(Transaction));
        } catch {
            return View();
        }
    }
}
