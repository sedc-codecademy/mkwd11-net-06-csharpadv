using TaxiManager.DomainModels.Models;

namespace TaxiManager.Services.Interfaces
{
    public interface IServiceBase<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetSingle(int id);
        void Add(T entity);
        void Remove(int id);
        void Seed(List<T> entities);
    }
}
