using TaxiManager.DataAccess;
using TaxiManager.DomainModels.Models;
using TaxiManager.Services.Interfaces;

namespace TaxiManager.Services.Implementations
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        protected IDb<T> _db;

        public ServiceBase()
        {
            _db = new LocalDb<T>();
        }


        public void Add(T entity)
        {
            _db.Insert(entity);
        }

        public List<T> GetAll()
        {
            return _db.GetAll();
        }

        public T GetSingle(int id)
        {
            return _db.GetById(id);
        }

        public void Remove(int id)
        {
            _db.DeleteById(id);
        }

        public void Seed(List<T> entities)
        {
            if (_db.GetAll().Count > 0)
                return;
            entities.ForEach(x => _db.Insert(x));
        }
    }
}
