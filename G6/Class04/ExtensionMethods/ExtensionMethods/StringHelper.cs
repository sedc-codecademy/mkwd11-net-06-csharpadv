using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringHelper
    {
        /// <summary>
        /// Extension methods, enable you to "add" methods to existing type without creating
        /// a new derived type or otherwise modifying the original type. Extension methods are 
        /// a special kind of static methods, but they are called as if they were instance methods on 
        /// the extended type.
        /// NOTE : The first parameter specifies which type we are extending(string in our example)
        /// and the parameter is preceded by the this keyword always.
        /// In this example, method takes two parameters, string and number of words that we need
        /// to show from that string. 
        /// First we are doing some validations and preventing the user from sending a negative number
        /// or an empty string. This is a good pracitse in programming called "defensive programming".
        /// </summary>
        public static string Shorten(this string text, int numOfWords)
        {
            if(numOfWords <= 0)
            {
                return "";
            }

            if (string.IsNullOrEmpty(text))
            {
                return "";
            }

            string[] words = text.Split(' ');

            if(words.Length < numOfWords)
            {
                return text;
            }

            List<string> resultWords = words.Take(numOfWords).ToList();

            string result = string.Join(" ", resultWords);
            return result;
        }
    }
}
