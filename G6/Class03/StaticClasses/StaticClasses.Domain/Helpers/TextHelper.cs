using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses.Domain.Helpers
{
    public static class TextHelper
    {
        public static string ToCapitalFirstLetter(string word)
        {
            if(string.IsNullOrEmpty(word))
            {
                return string.Empty; //""
            }
            else if(word.Length == 1)
            {
                return char.ToUpper(word[0]).ToString();
                //return word.ToUpper();
            }
            else
            {
                //sEdc -> Sedc
                //return char.ToUpper(word[0]) + word.Substring(1);
                return word.Substring(0, 1).ToUpper() + word.Substring(1);
            }
        }

        public static int ValidateNumberInput(string input)
        {
            int choice = 0;
            bool success = int.TryParse(input, out choice);

            if (success)
            {
                return choice;
            }
            else
            {
                return -1;
            }
        }
    }
}
