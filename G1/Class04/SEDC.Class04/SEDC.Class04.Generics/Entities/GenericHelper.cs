using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class04.Generics.Entities
{
    public class GenericHelper
    {
        public void GoThroughList<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfoForList<T>(List<T> list)
        {
            Console.WriteLine($"The list has {list.Count} elements and the elements are of type {typeof(T)}");

        }

        public void WriteLine<T>(T input)
        {
            Console.WriteLine(input);
        }

    }
}
