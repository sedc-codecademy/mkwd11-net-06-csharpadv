using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Generics.Domain.Models
{
    public class GenericDb<T> where T : BaseEntity
    {
        //Convection for private _text
        private List<T> _list { get; set; } = new List<T>();
        public GenericDb()
        {
        }

        public void PrintAll()
        {
            foreach (T item in _list)
            {
                Console.WriteLine(item.GetInfo());
            }
        }

        public void Insert(T item)
        {
            _list.Add(item);
            //item.GetType().Name is a C# code that retrieves the type of the object item and returns its name as a string.
            Console.WriteLine($"Item was added in the {item.GetType().Name} Db");
        }

        public T GetById(int id)
        {
            return _list.FirstOrDefault(x=> x.Id == id);
        }

        public T GetByIndex(int index)
        {
            return _list[index];
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
