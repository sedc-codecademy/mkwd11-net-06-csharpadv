using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Helpers
{
    public static class StringHelper
    {
        public static string Shorten(this string str, int numberOfWords) 
        {
            string[] words = str.Split(" ");

            List<string> substring = words.Take(numberOfWords).ToList();

            string result = string.Join(" ", substring);

            return $"{result}...";
        }

        public static string QuoteString(this string text) 
        {
            return '"' + text + '"';
        }
    }
}
