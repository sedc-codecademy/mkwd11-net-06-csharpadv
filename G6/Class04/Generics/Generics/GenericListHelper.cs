using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class GenericListHelper<T>
    {
        public static void PrintList(List<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintListInfo(List<T> items)
        {
            Console.WriteLine($"The list has {items.Count} members. They are of type {items.First().GetType().Name}");
        }
    }
}
