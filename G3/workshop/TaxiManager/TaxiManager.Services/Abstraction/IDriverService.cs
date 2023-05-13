using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;

namespace TaxiManager.Services.Abstraction
{
    public interface IDriverService : IServiceBase<Driver>
    {
        void AssignDriver(Driver driver, Car car);
        void UnassignDriver(Driver driver);
        bool IsAvailableDriver(Driver driver);
    }
}
