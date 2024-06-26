using CodeDrivers.Models;
using CodeDrivers.Models.Car;
using CodeDriversMVC.Models;
using CodeDriversMVC.Services.Interfaces;
using CodeDriversMVC.DataAccess;

namespace CodeDriversMVC.Services
{
    public class CarService : IRepository<Car>
    {
        private readonly CodeDriversContext _context;
        private readonly ReservationService _reservationService;
        public CarService(CodeDriversContext context, ReservationService reservationService)
        {
            _context = context;
            _reservationService = reservationService;
        }
        public void Create(Car car)
        {
            car.IsAvailable = true;
            _context.Set<Car>().Add(car);
            _context.SaveChanges();
        }
        public Car GetById(int id)
        {
            return _context.Set<Car>().FirstOrDefault(car => car.Id == id);
        }

        public List<Car> GetByAllFilters(CarBrand? brand, CarSegment? segment, GearType? gearType, MotorType? motorType, DateTime start, DateTime end)
        {
            var reservations = _reservationService.GetAvailableReservationsByPeriod(start, end);
            var reservedCarsIds = reservations.Select(c => c.Car.Id);


            return _context.Set<Car>()
                           .Where(car => (car.Brand == brand &&
                                          car.Segment == segment &&
                                          car.GearTransmission == gearType &&
                                          car.Motor == motorType) &&
                                          !reservedCarsIds.Contains(car.Id))
                                          .ToList();
        }

        public List<Car> GetByPeriod(DateTime start, DateTime end)
        {
            var reservations = _reservationService.GetAvailableReservationsByPeriod(start, end);
            var reservedCarsIds = reservations.Select(c => c.Car.Id);


            return _context.Set<Car>().Where(x => !reservedCarsIds.Contains(x.Id)).ToList();
        }

        public List<Car> GetAll()
        {
            return _context.Set<Car>().ToList();
        }

        public List<Car> GetAllAvailable(DateTime start, DateTime end)
        {
            var reservations = _reservationService.GetAvailableReservationsByPeriod(start, end);
            var reservedCarsIds = reservations.Select(c => c.Car.Id);
            return _context.Set<Car>().Where(x => !reservedCarsIds.Contains(x.Id)).ToList();
        }

        public void Update(Car updatedCar)
        {
            Car carToBeUpdated = GetById(updatedCar.Id);
            carToBeUpdated.Brand = updatedCar.Brand;
            carToBeUpdated.Model = updatedCar.Model;
            carToBeUpdated.Segment = updatedCar.Segment;
            carToBeUpdated.GearTransmission = updatedCar.GearTransmission;
            carToBeUpdated.PricePerDay = updatedCar.PricePerDay;
            carToBeUpdated.IsAvailable = updatedCar.IsAvailable;

            _context.Set<Car>().Update(carToBeUpdated);
            _context.SaveChanges();
        }
        public void Remove(int id)
        {
            Car carToBeRemoved = GetById(id);
            if (carToBeRemoved != null)
            {
                _context.Set<Car>().Remove(carToBeRemoved);
                _context.SaveChanges();
            }
        }

        public string UploadImage(IFormFile imageFile)
        {

            string uniqueFileName = Guid.NewGuid().ToString().Substring(0, 4) + "_" + imageFile.FileName;

            string uploadsFolder = @"wwwroot\Images";

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                imageFile.CopyTo(fileStream);
            }
            return uniqueFileName;
        }
    }
}
