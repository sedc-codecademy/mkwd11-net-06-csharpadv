using App.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Infrastructure
{
    public interface IDatabase<T> where T : BaseEntity
    {
        T Insert(T item); // create
        T Update(T item); // update
        bool Delete(int id); // delete
        List<T> GetAll(); // get all
        T GetSingle(int id); // get by id
    }
}
