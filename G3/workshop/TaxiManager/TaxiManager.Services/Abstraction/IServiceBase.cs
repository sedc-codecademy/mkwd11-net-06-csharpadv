using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Models;

namespace TaxiManager.Services.Abstraction
{
    public interface IServiceBase<T> where T : BaseEntity
    {
        List<T> GetAll();
        List<T> GetAll(Func<T, bool> wherePredicate);
        T GetSingle(int id);
        void Add(T item);
        void Remove(int id);
        void Seed(List<T> items);
    }
}
