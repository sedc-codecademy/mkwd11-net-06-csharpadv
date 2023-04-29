using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Exercise
{
    public static class Calculate
    {
        public static int Add(int first, int second) => first + second;
        public static int Divide(int first, int second) => first / second;
        public static int Multiply(int first, int second) => first * second;
        public static int Subtract(int first, int second) => first - second;

        public static int Execute(int first, int second, Operation op)
        {
            var result = op switch
            {
                Operation.Add => Add(first, second),
                Operation.Subtract => Subtract(first, second),
                Operation.Multiply => Multiply(first, second),
                Operation.Divide => Divide(first, second),
                _ => throw new InvalidOperationException("Invalid operation")
            };

            Logger.Log(first, second, op, result);

            return result;
        }
    }
}
