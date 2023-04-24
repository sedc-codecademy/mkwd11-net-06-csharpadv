using TaxiManager.DomainModels.Models;

namespace TaxiManager.Services.Interfaces
{
    public interface IDriverService : IServiceBase<Driver>
    {
        void AssignDriver(Driver driver, Car car);
        void UnassignDriver(Driver driver);
        bool IsDriverAvailable(Driver driver);
    }
}
