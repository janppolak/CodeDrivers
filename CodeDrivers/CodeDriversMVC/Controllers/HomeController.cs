using CodeDriversMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CodeDrivers.Models.Car;
using CodeDrivers;
using CodeDriversMVC.Services;
using CodeDrivers.Repository;
using CodeDriversMVC.DataAccess;

namespace CodeDriversMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CarService _carService;
        private readonly ReservationService _reservationService;

        public HomeController(ILogger<HomeController> logger, CarService carService, ReservationService reservationService)
        {
            _logger = logger;
            _carService = carService;
            _reservationService = reservationService;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["DateStart"] = DateTime.Now;
            ViewData["DateEnd"] = DateTime.Now;

            var carsByPeriod = _carService.GetByPeriod(DateTime.Now, DateTime.Now);

            var result = await CatService.GetCatFunFactAsync();

            return View(carsByPeriod);
        }
        [HttpPost]
        public IActionResult Index(string? searchTextBrand, string? segmentDropdownText, string? gearTypeDropdownText, string? motorTypeDropdownText, DateTime dateStart, DateTime dateEnd)
        {
            IEnumerable<Car> filteredCars = _carService.GetAll();
            
            if (!string.IsNullOrEmpty(searchTextBrand) && Enum.TryParse(searchTextBrand, out CarBrand brand))
            {
                filteredCars = filteredCars.Where(car => car.Brand == brand);
            }

            if (!string.IsNullOrEmpty(segmentDropdownText) && Enum.TryParse(segmentDropdownText, out CarSegment segment))
            {
                filteredCars = filteredCars.Where(car => car.Segment == segment);
            }

            if (!string.IsNullOrEmpty(gearTypeDropdownText) && Enum.TryParse(gearTypeDropdownText, out GearType gearType))
            {
                filteredCars = filteredCars.Where(car => car.GearTransmission == gearType);
            }

            if (!string.IsNullOrEmpty(motorTypeDropdownText) && Enum.TryParse(motorTypeDropdownText, out MotorType motorType))
            {
                filteredCars = filteredCars.Where(car => car.Motor == motorType);
            }
            var carsByPeriod = _carService.GetByPeriod(dateStart, dateEnd);
            filteredCars = filteredCars.Intersect(carsByPeriod);

            ViewData["SearchTextBrand"] = searchTextBrand;
            ViewData["SegmentDropdownText"] = segmentDropdownText;
            ViewData["GearTypeDropdownText"] = gearTypeDropdownText;
            ViewData["MotorTypeDropdownText"] = motorTypeDropdownText;
            ViewData["DateStart"] = dateStart;
            ViewData["DateEnd"] = dateEnd;


            return View(filteredCars);
        }

        public IActionResult About()
        {
            return View();
        }
        [HttpPost]

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Footer()
        {
            return View();
        }
    }
}