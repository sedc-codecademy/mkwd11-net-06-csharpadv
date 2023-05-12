using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Domain.Enums;
using TaxiManagerApp9000.Services.Interfaces;

namespace TaxiManagerApp9000.Services
{
    public class CarService : BaseService<Car>, ICarService
    {
        public bool AssignDriver(Driver driver, Car car)
        {
            car.AssignedDrivers.Add(driver);
            _db.Update(car);
            return true;
        }

        public List<Car> GetAvailableCarsInShift(Shift shift)
        {
            List<Car> cars = _db.GetAll().Where(x => x.LicensePlateExpiryDate > DateTime.Now
                && !x.AssignedDrivers.Any(y => y.Shift == shift)).ToList();

            return cars;
        }

        public bool IsAvailableCar(Car car) =>
            car.IsLicenseExpired() == ExpiryStatus.Expired || car.AssignedDrivers.Count == 3 ? false : true;
    }
}
