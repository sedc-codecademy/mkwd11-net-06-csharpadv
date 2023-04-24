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
    }
}
