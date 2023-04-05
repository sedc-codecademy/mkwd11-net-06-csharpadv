using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.ExtensionMethod.Helpers
{
    public static class ExstensionMethodHelper
    {
        /// <summary>
        /// Extension method for quoting a string. This method as a parameter
        /// takes one text of type string and we are just returning the same
        /// text but in quotes. Note again the this keyword in the first parameter..
        /// </summary>
        public static string QuoteString(this string text, int test)
        {
            return '"' + text + test + '"';
        }

        public static void GenericHelpers<T>(this List<T> item)
        {
            foreach (T item2 in item)
            {
                Console.WriteLine(item2);
            }
        }
    }
}
