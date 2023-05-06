using TaxiManagerApp9000.DataAccess;
using TaxiManagerApp9000.DataAccess.Interfaces;
using TaxiManagerApp9000.Domain.Entities;
using TaxiManagerApp9000.Services.Interfaces;

namespace TaxiManagerApp9000.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private IDb<T> Db;

        public BaseService()
        {
            Db = new FileSystemDb<T>();
        }

        public bool Add(T entity)
        {
            try
            {
                Db.Add(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<T> GetAll()
        {
            return Db.GetAll();
        }

        public T GetById(int id)
        {
            return Db.GetById(id);
        }

        public bool Remove(int id)
        {
            return Db.RemoveById(id);
        }

        public void Seed(List<T> items)
        {
            List<T> data = Db.GetAll();
            if (data != null && data.Count > 0)
            {
                return;
            }

            items.ForEach(x => Db.Add(x));
        }
    }
}
