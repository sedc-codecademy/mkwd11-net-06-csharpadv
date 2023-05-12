using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.DataAccess;
using TaxiManager.Domain.Models;
using TaxiManager.Services.Abstraction;

namespace TaxiManager.Services.Implementation
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : BaseEntity
    {
        protected IDb<T> _db;

        public ServiceBase()
        {
            _db = new LocalDb<T>();
        }
        public void Add(T item)
        {
            _db.Insert(item);
        }

        public List<T> GetAll()
        {
            return _db.GetAll();
        }

        public List<T> GetAll(Func<T, bool> wherePredicate)
        {
            return _db.GetAll().Where(wherePredicate).ToList();
        }

        public T GetSingle(int id)
        {
            return _db.GetById(id);
        }

        public void Remove(int id)
        {
            _db.RemoveById(id);
        }

        public void Seed(List<T> items)
        {
            if (_db.GetAll().Count > 0) 
            {
                return;
            }

            items.ForEach(item => _db.Insert(item));

            //foreach (var item in items)
            //{
            //    _db.Insert(item);
            //}
        }
    }
}
