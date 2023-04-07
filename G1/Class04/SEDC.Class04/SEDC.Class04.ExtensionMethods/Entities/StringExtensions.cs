using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class04.ExtensionMethods.Entities
{
    public static class StringExtensions
    {
        public static string DeleteLastLetter(this string str)
        {
            return str.Substring(0, str.Length - 1);
        }

        public static string GetStringFromPosition(this string str,  int fromPosition)
        {
            return str.Substring(fromPosition);
        }

        public static string AddQuatations(this string str)
        {
            return $@"""{str}""";
        }
    }
}
