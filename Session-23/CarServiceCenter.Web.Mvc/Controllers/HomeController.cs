using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using CarServiceCenter.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly IEntityRepo<Car> _CarRepo;
        private readonly IEntityRepo<Customer> _CustomerRepo;
        private readonly IEntityRepo<Engineer> _EngineerRepo;
        private readonly IEntityRepo<Manager> _ManagerRepo;
        private readonly IEntityRepo<ServiceTask> _ServiceTaskRepo;
        private readonly IEntityRepo<Transaction> _TransactionRepo;
        private readonly IEntityRepo<TransactionLine> _TransactionLineRepo;


        public HomeController(ILogger<HomeController> logger,
                IEntityRepo<Car> carRepo,
                IEntityRepo<Customer> customerRepo,
                IEntityRepo<Engineer> engineerRepo,
                IEntityRepo<Manager> managerRepo,
                IEntityRepo<ServiceTask> serviceTaskRepo,
                IEntityRepo<Transaction> transactionRepo,
                IEntityRepo<TransactionLine> transactionLineRepo) {
            _logger = logger;
            _CarRepo = carRepo;
            _CustomerRepo = customerRepo;
            _EngineerRepo = engineerRepo;
            _ManagerRepo = managerRepo;
            _ServiceTaskRepo = serviceTaskRepo;
            _TransactionRepo = transactionRepo;
            _TransactionLineRepo = transactionLineRepo;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}