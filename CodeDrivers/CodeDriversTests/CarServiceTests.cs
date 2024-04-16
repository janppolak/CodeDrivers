using CodeDrivers.Models.Car;
using CodeDriversMVC.Services;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace CodeDriversTests
{
    public class CarServiceTests
    {
        [Fact]
        public void CreateCate_CreateCar_WhenCalled_ShouldSetIsAvailableToTrueAndSaveChanges()
        {
            // Arrange
            var data = new List<Car>
            {
                new Car { Id = 1, Brand = CarBrand.Audi, Model = "A4", Motor = MotorType.Benzynowy, GearTransmission = GearType.Automatyczna, IsAvailable = true}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Car>>();
            mockSet.As<IQueryable<Car>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Car>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Car>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Car>>().Setup(m => m.GetEnumerator()).Returns(() => data.GetEnumerator());

            var mockContext = new Mock<CodeDriversMVC.DataAccess.CodeDriversContext>();
            mockContext.Setup(c => c.Cars).Returns(mockSet.Object);

            var mockRevervationService = new Mock<ReservationService>(); 
            var carService = new CarService(mockContext.Object, mockRevervationService.Object);

            var newCar = new Car { Id = 2, Brand = CarBrand.BMW, Model = "X5", Motor = MotorType.Diesel, GearTransmission = GearType.Automatyczna, IsAvailable = true };

            // Act
            carService.Create(newCar);

            // Assert
            Assert.True(newCar.IsAvailable);
        }
    }
}
