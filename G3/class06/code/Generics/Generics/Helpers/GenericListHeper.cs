using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Helpers
{
    public class GenericListHeper<T>
    {
        public void GoTrough(List<T> items) 
        {
            foreach (T item in items) 
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoFor(List<T> items)
        {
            T firstElement = items[0];
            Console.WriteLine($"This list has {items.Count} " +
                $"members and is a type of {firstElement.GetType().Name}");
        }
    }
}
