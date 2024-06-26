using CodeDrivers.Models.Car;
using CodeDriversMVC.Constants;
using CodeDriversMVC.Helpers;
using CodeDriversMVC.Models;
using CodeDriversMVC.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeDriversMVC.Controllers
{
    public class CarController : Controller
    {
        private readonly CarService _carService;
        public CarController(CarService carService)
        {
            _carService = carService;
        }

        // GET: CarController
        public ActionResult Index()
        {
            var allCars = _carService.GetAll();
            return View(allCars);

        }


        // GET: CarController/Details/5
        public ActionResult Details(int id)
        {
            var allCars = _carService.GetById(id);
            return View(allCars);
        }

        // GET: CarController/Create
        public ActionResult Create()
        {
            return View(new Car());
        }

        // POST: CarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Car car)
        {
            if (CarPriceValidationHelper.IsPriceBelowMinimum(Constants.Constants.MinimalPricePerDay, car.PricePerDay))
            {
                ModelState.AddModelError("PriceIsLessThan50Error", "Cena wynajmu nie może być niższa niż 50 zł.");
                return View("Create", car);
            }
            else
            {
                car.ImageFileName = _carService.UploadImage(car.ImageFile);
                _carService.Create(car);
                TempData["Success"] = "Auto zostało dodane";
                return RedirectToAction(nameof(Index));
            }
        }

        // GET: CarController/Edit/5
        public ActionResult Edit(int id)
        {
            var allCars = _carService.GetById(id);
            return View(allCars);
        }

        // POST: CarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Car carToBeEdited)
        {
            _carService.Update(carToBeEdited);
            return RedirectToAction(nameof(Index));
        }

        // GET: CarController/Delete/5
        public ActionResult Delete(int id)
        {
            var carToBeDeleted = _carService.GetById(id);
            return View(carToBeDeleted);
        }

        // POST: CarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Car carToBeDeleted)
        {
            _carService.Remove(id);
            TempData["Delete"] = "Auto zostało usunięte.";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public ActionResult GetModelsForBrand(string name)
        {
            var dic = Car.GetDisctionary();

            var modelEnum = (CarBrand)Enum.Parse(typeof(CarBrand), name);
            var models = dic[modelEnum];

            return Json(models);

        }
        [HttpPost]
        public ActionResult GetCarSearchFilter(string name)
        {
            var dic = Car.GetDisctionary();

            if (name == "Wszystko")
            {
                var allModels = dic.Values.SelectMany(models => models).Distinct().ToList();
                return Json(allModels);
            }

            return View();
        }
    }
}
