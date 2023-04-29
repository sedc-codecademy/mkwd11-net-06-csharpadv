using TaxiManagerApp9000.Domain.Entities;

namespace TaxiManagerApp9000.Services
{
    public class CarService : BaseService<Car>
    {
        public List<Car> GetAllCars()
        {
            return GetAll();
        }
    }
}
