using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Exercise
{
    public class ConsoleReader
    {
        public int ReadInteger()
        {
            var input = Console.ReadLine();

            if (!int.TryParse(input, out int result))
            {
                throw new ApplicationException($"{input} is not a valid integer");
            }

            return result;
        }

        public Operation ReadOperation()
        {
            var input = Console.ReadLine().Trim();

            var result = input switch
            {
                "+" => Operation.Add,
                "-" => Operation.Subtract,
                "*" => Operation.Multiply,
                "/" => Operation.Divide,
                _ => Operation.Invalid,
            };

            return result;
        }
    }
}
