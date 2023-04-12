using App.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Infrastructure
{
    public class Database<T> : IDatabase<T> where T : BaseEntity
    {
        public List<T> Data { get; set; } = new List<T>();
        public T Insert(T item)
        {
           item.Id++;
           Data.Add(item);
           return item;
        }

        public bool Delete(int id)
        {
           var item = Data.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                Data.Remove(item);
                return true;
            }
            else
            {
                throw new Exception("The item does not exists");
            }
        }

        public List<T> GetAll()
        {
            return Data;
        }

        public T GetSingle(int id)
        {
            var item = Data.FirstOrDefault(x => x.Id == id);
            if(item!=null)
            {
                return item;
            }
            else
            {
                throw new Exception("The item does not exists");
            }
        }

        public T Update(T item)
        {
            var oldItem = Data.FirstOrDefault(x => x.Id == item.Id);
            if(oldItem!=null)
            {
                oldItem = item;
                return item;
            }
            else
            {
                throw new Exception("The item does not exists");
            }
        }
    }
}
