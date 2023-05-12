using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;

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
            return _db.SingleOrDefault(entity => entity.Id == id);
        }

        public int Insert(T entity)
        {
            entity.Id = IdCount;
            _db.Add(entity);
            IdCount++;
            return entity.Id;
        }

        public void RemoveById(int id)
        {
            T entity = _db.SingleOrDefault(entity => entity.Id == id);

            if (entity != null) 
            {
                _db.Remove(entity);
            }
        }

        public void Update(T entity)
        {
            T item = _db.SingleOrDefault(item => item.Id == entity.Id);
            item = entity;
        }
    }
}
