using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LinqExercise.Helpers
{
    public static class HelperMethods
    {
        public static void PrintList<T>(this List<T> list) 
        {
            list.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("==================");
        }

        public static void PrintString(this string str) 
        {
            Console.WriteLine(str);
            Console.WriteLine("==================");
        }
    }

}
