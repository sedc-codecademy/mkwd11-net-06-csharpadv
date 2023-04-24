using TaxiManager.DomainModels.Enums;
using TaxiManager.DomainModels.Models;
using TaxiManager.Services.Interfaces;

namespace TaxiManager.Services.Implementations
{
    public class DriverService : ServiceBase<Driver>, IDriverService
    {
        public void AssignDriver(Driver driver, Car car)
        {
            driver.Car = car;
            _db.Update(driver);
        }

        public bool IsDriverAvailable(Driver driver) =>
             driver.IsLicenseExpired() != ExpieryStatus.Expired;

        public void UnassignDriver(Driver driver)
        {
            driver.Car = null;
            _db.Update(driver);
        }
    }
}
