using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Enums;
using TaxiManager.Domain.Models;
using TaxiManager.Services.Abstraction;

namespace TaxiManager.Services.Implementation
{
    public class DriverService : ServiceBase<Driver>, IDriverService
    {
        public void AssignDriver(Driver driver, Car car)
        {
            driver.Car = car;
            _db.Update(driver);
        }

        public void UnassignDriver(Driver driver)
        {
            driver.Car = null;
            _db.Update(driver);
        }

        public bool IsAvailableDriver(Driver driver)
            => driver.IsLicenseExpired() == ExpieryStatus.Expired
            ? false : true;
    }
}
