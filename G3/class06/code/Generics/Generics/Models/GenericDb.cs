using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Models
{
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> Db;
        public GenericDb()
        {
            Db = new List<T>();
        }

        public void PrintAll() 
        {
            foreach (T item in Db) 
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void Insert(T item) 
        {
            Db.Add(item);
        }

        public T GetByIndex(int index) 
        {
            return Db[index];
        }

        public T GetById(int id) 
        {
            return Db.Single(item => item.Id == id);
        }

        public void RemoveById(int id) 
        {
            T item = Db.SingleOrDefault(item => item.Id == id);

            if (item == null) 
            {
                return;
            }

            Db.Remove(item);
        }
    }
}
