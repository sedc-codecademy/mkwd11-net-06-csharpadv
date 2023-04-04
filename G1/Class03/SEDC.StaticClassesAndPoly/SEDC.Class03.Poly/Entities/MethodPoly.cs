using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class03.Poly.Entities
{
    public class MethodPoly
    {
        // The methods can have same name, but must have different number of inputs
        // or same number of inputs but with different types



        /// <summary>
        ///  Method that will sum up two numbers
        /// </summary>
        /// <param name="a">The first number to be added</param>
        /// <param name="b">The second number to be added</param>
        /// <returns></returns>
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="third"></param>
        /// <returns></returns>
        public int AddNumbers(int first, int second, int third)
        {
            return first + second + third;
        }

        public int AddNumbers(string first, string second)
        {
            return int.Parse(first) + int.Parse(second);
        }

        public void AddNumbers(double first, double second)
        {
            Console.WriteLine(first + second);
        }

        public double AddNumbers(double first, double second, double third)
        {
            return first + second + third;
        }

        public double AddNumbers(int first, double second)
        {
            return first + second;
        }

        public double AddNumbers(double first, int second)
        {
            return first + second;
        }
    }
}
