using CarServiceCenter.EF.Repositories;
using CarServiceCenter.Model;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceCenter.Web.Mvc.Controllers {
    public class CarController : Controller {

        private readonly IEntityRepo<Car> _carRepo;
        public CarController(IEntityRepo<Car> carRepo) {
            _carRepo = carRepo;
        }

        // GET: CarController
        public ActionResult Car() {
            var cars = _carRepo.GetAll();
            return View(model: cars);
        }

        // GET: CarController/Details/5
        public ActionResult Details(int id) {
            return View();
        }

        // GET: CarController/Create
        public ActionResult Create() {
            return View();
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CarCreateDto car) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }
                var CarDb = new Car();
                CarDb.Brand = car.Brand;
                CarDb.Model = car.Model;
                CarDb.CarRegistrationNumber = car.CarRegistrationNumber;
                _carRepo.Add(CarDb);

                return RedirectToAction("Car");
            } catch {
                return View();
            }
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id) {
            var CarDb = _carRepo.GetById(id);
            if (CarDb == null) {
                return null;
            }

            var viewCar = new CarEditDto();
            viewCar.Brand = CarDb.Brand;
            viewCar.Model = CarDb.Model;
            viewCar.CarRegistrationNumber = CarDb.CarRegistrationNumber;
            return View(model: viewCar);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CarEditDto car) {
            try {
                if (!ModelState.IsValid) {
                    return View();
                }
                var CarDb = _carRepo.GetById(id);

                if (CarDb == null) {
                    return NotFound();
                }

                CarDb.Brand = car.Brand;
                CarDb.Model = car.Model;
                CarDb.CarRegistrationNumber = car.CarRegistrationNumber;
                _carRepo.Update(id, CarDb);
                return RedirectToAction(nameof(Car));
            } catch {
                return View();
            }
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id) {
            var CarDb = _carRepo.GetById(id);
            if (CarDb == null) {
                return NotFound();
            }

            var viewCar = new CarDeleteDto {
                Brand = CarDb.Brand,
                Model = CarDb.Model,
                CarRegistrationNumber = CarDb.CarRegistrationNumber
            };

            return View(model: viewCar);
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection) {
            try {

                _carRepo.Delete(id);
                return RedirectToAction(nameof(Car));

            } catch {
                return View();
            }
        }
    }
}