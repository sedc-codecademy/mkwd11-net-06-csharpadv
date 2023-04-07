using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class04.ExtensionMethods.Entities
{
    public static class ListExtensions
    {
        public static void PrintElements<T>(this List<T> listToPrint)
        {
            foreach (var item in listToPrint)
            {
                Console.WriteLine(item);
            }
        }
    }
}
