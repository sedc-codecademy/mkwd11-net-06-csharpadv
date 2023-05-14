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
    public class CarService : ServiceBase<Car>, ICarService
    {
        public bool IsAvailableCar(Car car) 
            => car.IsLicensePlateExpired() == ExpieryStatus.Expired 
            ? false : true;

        //public bool IsAvailableCar(Car car)
        //{
        //    if (car.IsLicensePlateExpired() == ExpieryStatus.Expired)
        //    {
        //        return false;
        //    }
        //    else 
        //    {
        //        return true;
        //    }
        //}
    }
}
