using TaxiManager.DomainModels.Enums;
using TaxiManager.DomainModels.Models;
using TaxiManager.Services.Interfaces;

namespace TaxiManager.Services.Implementations
{
    public class CarService : ServiceBase<Car>, ICarService
    {
        public bool IsCarAvailable(Car car) =>
            car.IsLicenseExpired() != ExpieryStatus.Expired && car.AssignedDrivers.Count != 3;
    }
}
