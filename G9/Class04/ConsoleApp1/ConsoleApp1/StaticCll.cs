using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StaticCll
    {
        public static void PrintAllString(List<string> str)
        {
            foreach (string str2 in str)
            {
                Console.WriteLine(str2);
            }
        }

        public static int PrintAllInt(List<int> ints)
        {
            foreach (int str2 in ints)
            {
                Console.WriteLine(str2);
            }
            return 0;
        }
    }
}
