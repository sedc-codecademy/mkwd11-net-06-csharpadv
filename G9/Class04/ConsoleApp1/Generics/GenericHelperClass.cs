using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericHelperClass<T>
    {
        public void PrintAll(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }

        }

        public void GetInfo(List<T> list)
        {
            Console.WriteLine($"The list is {list.Count} long");
        }
    }
}
