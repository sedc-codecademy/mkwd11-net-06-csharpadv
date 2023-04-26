using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.DomainModels.Models;

namespace TaxiManager.Services.Interfaces
{
    public interface ICarService : IServiceBase<Car>
    {
        bool IsCarAvailable(Car car);
    }
}
