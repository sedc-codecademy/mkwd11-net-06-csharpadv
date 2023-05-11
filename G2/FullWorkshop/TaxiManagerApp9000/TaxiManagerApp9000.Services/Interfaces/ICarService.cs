using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Domain.Enums;

namespace TaxiManagerApp9000.Services.Interfaces
{
    public interface ICarService : IBaseService<Car>
    {
        bool IsAvailableCar(Car car);

        void Seed(List<Car> seedCars);

        bool AssignDriver(Driver driver, Car car);

        List<Car> GetAvailableCarsInShift(Shift shift);
    }
}
