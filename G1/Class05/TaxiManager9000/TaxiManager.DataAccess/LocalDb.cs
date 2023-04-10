using TaxiManager.DomainModels.Models;

namespace TaxiManager.DataAccess
{
    public class LocalDb<T> : IDb<T> where T : BaseEntity
    {
        private List<T> _db;
        public int IdCount { get; set; }


        public LocalDb()
        {
            _db = new List<T>();
            IdCount = 1;
        }
        public List<T> GetAll()
        {
            return _db;
        }
        public T GetById(int id)
        {
            return _db.SingleOrDefault(x => x.Id == id);
        }
        public int Insert(T entity)
        {
            entity.Id = IdCount++;
            _db.Add(entity);
            return entity.Id;
        }

        public void Update(T entity)
        {
            T item = _db.SingleOrDefault(x => x.Id == entity.Id);
            item = entity;
        }

        public void DeleteById(int id)
        {
            T item = _db.SingleOrDefault(x => x.Id == id);
            if(item != null)
                _db.Remove(item);
        }
    }
}
