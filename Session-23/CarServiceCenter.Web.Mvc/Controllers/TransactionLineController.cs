
using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Mvc.Models.Engineer;
using CarServiceCenter.Web.Mvc.Models.Transaction;
using CarServiceCenter.Web.Mvc.Models.TransactionLine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CarServiceCenter.Web.Mvc.Controllers; 
public class TransactionLineController : Controller {

    private readonly IEntityRepo<TransactionLine> _transactionLineRepo;
    private readonly IEntityRepo<Transaction> _transactionRepo;
    private readonly IEntityRepo<ServiceTask> _serviceTaskRepo;
    private readonly IEntityRepo<Engineer> _engineerRepo;
    TransactionLineCreateDto transactionLineCreateDto = new TransactionLineCreateDto();

    public TransactionLineController(IEntityRepo<TransactionLine> transactionLineRepo,
                                     IEntityRepo<Transaction> transactionRepo,
                                     IEntityRepo<ServiceTask> serviceTaskRepo,
                                     IEntityRepo<Engineer> engineerRepo) {
        _transactionLineRepo = transactionLineRepo;
        _transactionRepo = transactionRepo;
        _serviceTaskRepo = serviceTaskRepo;
        _engineerRepo = engineerRepo;
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
        transactionLineCreateDto.Price = transactionLineCreateDto.CalculatePrice();

        var newTransactionLine = new TransactionLineCreateDto();
        var transactions = _transactionRepo.GetAll();
        foreach (var transaction in transactions) {
            newTransactionLine.Transactions.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(transaction.Date.ToString(), transaction.Id.ToString()));
        }

        var serviceTasks = _serviceTaskRepo.GetAll();
        foreach (var serviceTask in serviceTasks) {
            newTransactionLine.ServiceTasks.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(serviceTask.Description, serviceTask.Id.ToString()));
        }

        var engineers = _engineerRepo.GetAll();
        foreach (var engineer in engineers) {
            newTransactionLine.Engineers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(engineer.Surname, engineer.Id.ToString()));
        }

        return View(model: newTransactionLine);

    }

    // POST: TransactionLineController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(TransactionLineCreateDto transactionLine) {
        try {
            if (!ModelState.IsValid) {
                return View();
            }

            var TransactionLineDb = new TransactionLine();
            TransactionLineDb.Hours = transactionLine.Hours;
            TransactionLineDb.PricePerHour = transactionLine.PricePerHour;
			TransactionLineDb.Price = TransactionLineDb.CalculatePrice(transactionLine.Hours, transactionLine.PricePerHour);
			TransactionLineDb.TransactionId = transactionLine.TransactionId;
            TransactionLineDb.ServiceTaskId = transactionLine.ServiceTaskId;
            TransactionLineDb.EngineerId = transactionLine.EngineerId;

            _transactionLineRepo.Add(TransactionLineDb);

            return RedirectToAction("TransactionLine");
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
		var TransactionLineDb = _transactionLineRepo.GetById(id);
		if (TransactionLineDb == null) {
			return NotFound();
		}

		var viewTransactionLine = new TransactionLineDeleteDto {
            Hours = TransactionLineDb.Hours,
            PricePerHour = TransactionLineDb.PricePerHour,
            Price = TransactionLineDb.Price,
            TransactionId = TransactionLineDb.TransactionId,
            ServiceTaskId = TransactionLineDb.ServiceTaskId,
            EngineerId = TransactionLineDb.EngineerId
        };

		return View(model: viewTransactionLine);
	}

    // POST: TransactionLineController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection) {
		try {
			_transactionLineRepo.Delete(id);
			return RedirectToAction(nameof(TransactionLine));
		} catch {
			return View();
		}
	}
}
