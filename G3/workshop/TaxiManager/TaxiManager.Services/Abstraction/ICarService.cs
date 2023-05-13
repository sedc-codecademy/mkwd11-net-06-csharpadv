using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;

namespace TaxiManager.Services.Abstraction
{
    public interface ICarService : IServiceBase<Car>
    {
        bool IsAvailableCar(Car car);
    }
}
