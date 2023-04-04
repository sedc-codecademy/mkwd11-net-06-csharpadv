using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class03.Utils
{
    public static class StringUtils
    {
        public static string CapitaliseFirstLetter(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                //throw new Exception("Cannot insert null value.");
                return string.Empty;
            }

            char firstLetter = text[0];
            string capitalFirstLetter = firstLetter.ToString().ToUpper();

            if(text.Length == 1)
            {
                return capitalFirstLetter;
            }
            
            return $"{capitalFirstLetter}{text.Substring(1)}";
        }

        public static int VerifyStringNumber(string input)
        {
            int result = 0;
            bool isParsed = int.TryParse(input, out result);
            if(isParsed)
            {
                return result;
            }
            else
            {
                return -1;
            }
        }
    }
}
