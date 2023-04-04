using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Generics.Domain.Models
{
    public class GenericDb<T> where T : BaseEntity
    {
        private List<T> _list { get; set; } = new List<T>();
        public GenericDb()
        {
        }

        public void PrintAll()
        {
            foreach (T item in _list)
            {
                Console.WriteLine(item);
            }
        }

        public void Insert(T item)
        {
            _list.Add(item);
            Console.WriteLine($"Item was added in the {item.GetType().Name} Db");
        }

        public T GetById(int id)
        {
            return _list.FirstOrDefault(x=> x.Id == id);
        }

        public void Remove(int id)
        {
            T item = _list.FirstOrDefault(x => x.Id == id);
            if(item == null)
            {
                Console.WriteLine("Item was not found");
                
            }
            _list.Remove(item);
            Console.WriteLine($"Item was removed in the {item.GetType().Name} Db");
        }
        
    }
}
