using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Generics.Helpers
{
    /// <summary>
    /// Generic class with couple of generic methods
    /// How we know it is generic? Of course the T parameter 
    /// in angle brackets after the class name ..
    /// </summary>
    public static class GenericListHelpers<T>
    {
        /// <summary>
        /// The same method that we have in the non generic class, we iterate through some list
        /// and print the output. What is the difference? The difference is here we don't know
        /// if its from type string or int like we knew in the non generic method. We have created
        /// two methods there, one that goes through the list of ints and another method that goes 
        /// through the list of strings. Here with generic method, you can notice we get reusability 
        /// of the code. We can use this method if the user wants to provide list of integers or strings.
        /// </summary>
        /// <param name="items"></param>
        public static void ListGenrericMethod(List<T> items)
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }

        // No generic methods
        //public static void ListGenrericMethod(List<string> items)
        //{
        //    foreach (string item in items)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        //public static void ListGenrericMethod(List<int> items)
        //{
        //    foreach (int item in items)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

    }
}
