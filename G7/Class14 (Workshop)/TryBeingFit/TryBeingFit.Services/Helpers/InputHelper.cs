using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryBeingFit.Services.Helpers
{
    public static class InputHelper
    {
        public static int InputNumber()
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int number))
            {
                throw new Exception("Wrong input/selection!");
            }

            return number;
        }

        public static DateTime InputDateTime()
        {
            string input = Console.ReadLine();

            if (!DateTime.TryParse(input, out DateTime dateTime))
            {
                throw new Exception("Wrong dateTime!");
            }

            return dateTime;
        }
    }
}
