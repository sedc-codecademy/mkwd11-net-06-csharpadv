using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.GoodPractices.Practices
{
    public class IfElse
    {
        public void IfElseExample(int num1, int num2)
        {
            //Bad example
            // Check if two numbers are the same but only from 0 to 100 even numbers

            if(num1 <= 100 && num2 <= 100)
            {
                if(num1 % 2 == 0 && num2 % 2 == 0)
                {
                    if(num1 == num2)
                    {
                        Console.WriteLine("The numbers are same!");
                    }
                }
            }


            //Good example
            if (num1 > 100 || num2 > 100) return;
            if (num1 % 2 != 0 || num2 % 2 != 0) return;
            if (num1 != num2) return;
            Console.WriteLine("They are same!");

        }
    }
}
