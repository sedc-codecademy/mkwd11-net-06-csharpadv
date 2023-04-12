using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Helpers
{
    public static class ListHelper
    {
        public static void GoTrough<T>(this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void GetInfoFor<T>(this List<T> items)
        {
            T firstElement = items[0];
            Console.WriteLine($"This list has {items.Count} " +
                $"members and is a type of {firstElement.GetType().Name}");
        }
    }
}
