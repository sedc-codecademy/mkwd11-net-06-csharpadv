using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_Demo03
{
    public static class StringHelper
    {
        public static string ToTitleCase(this string input)
        {
            TextInfo ti = new CultureInfo("mk-MK").TextInfo;
            return ti.ToTitleCase(input);
        }

        public static string Replicate(this string input, int n)
        {
            string result = string.Empty;
            for(int i = 0; i < n; i++)
            {
                result += input + "\n";
            }

            return result;
        }
    }
}
