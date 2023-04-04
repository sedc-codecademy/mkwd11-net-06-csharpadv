using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class03.Utils
{
    public static class FirstStaticClass
    {
        public static int Counter { get; set; }

        static FirstStaticClass()
        {
            Counter = 1;
        }


        public static int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }


        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
