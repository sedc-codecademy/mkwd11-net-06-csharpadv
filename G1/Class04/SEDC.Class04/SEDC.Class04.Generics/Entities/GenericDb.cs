using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class04.Generics.Entities
{
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> items;

        public GenericDb()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine($"New item of type {typeof(T)} was added");
        }

        public void Remove(T item)
        {
            items.Remove(item);
        }

        public void PrintInfo()
        {
            foreach(T item in items)
            {
                item.Print();
            }
        }

        public T GetById(int id)
        {
            return items.Where(x => x.Id == id).FirstOrDefault();
        }

        public int GetItemsCount()
        {
            return items.Count;
        }
    }
}
