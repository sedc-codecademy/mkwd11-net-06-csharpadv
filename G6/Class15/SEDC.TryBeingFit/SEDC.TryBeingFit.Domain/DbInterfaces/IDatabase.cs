using SEDC.TryBeingFit.Domain.Models;

namespace SEDC.TryBeingFit.Domain.DbInterfaces
{
    public interface IDatabase<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Add(T entity);
        void RemoveById(int id);
        void Update(T entity);
    }
}
