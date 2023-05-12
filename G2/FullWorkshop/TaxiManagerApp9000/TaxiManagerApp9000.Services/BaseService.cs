using TaxiManagerApp9000.DataAccess;
using TaxiManagerApp9000.DataAccess.Interfaces;
using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Services.Interfaces;

namespace TaxiManagerApp9000.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        protected IDb<T> _db;

        public BaseService()
        {
            _db = new FileSystemDb<T>();
        }
        public bool Add(T entity)
        {
            try
            {
                _db.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<List<T>> GetAll()
        {
            await Task.Delay(2000);
            return _db.GetAll();
        }

        public List<T> GetAll(Func<T, bool> wherePredicate)
        {
            return _db.GetAll().Where(wherePredicate).ToList();
        }

        public T GetById(int id)
        {
            return _db.GetById(id);
        }

        public bool Remove(int id)
        {
            return _db.RemoveById(id);
        }

        public void Seed(List<T> items)
        {
            List<T> data = _db.GetAll();
            if (data != null && data.Count > 0)
            {
                return;
            }

            items.ForEach(x => _db.Add(x));
        }
    }
}
