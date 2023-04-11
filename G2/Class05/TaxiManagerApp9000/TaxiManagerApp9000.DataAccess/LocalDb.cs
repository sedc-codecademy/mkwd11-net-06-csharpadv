using TaxiManagerApp9000.DataAccess.Interfaces;
using TaxiManagerApp9000.Domain.Entities;

namespace TaxiManagerApp9000.DataAccess
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        public int IdCounter { get; set; }

        private List<T> db;

        public LocalDb()
        {
            db = new List<T>();
            IdCounter = 1;
        }

        public int Add(T entity)
        {
            entity.Id = IdCounter++;
            db.Add(entity);

            return entity.Id;
        }

        public List<T> GetAll()
        {
            return db;
        }

        public T GetById(int id)
        {
            return db.Single(x => x.Id == id);
        }

        public bool RemoveById(int id)
        {
            try
            {
                T entity = GetById(id);
                db.Remove(entity);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                T dbEntity = GetById(entity.Id);

                dbEntity = entity;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
