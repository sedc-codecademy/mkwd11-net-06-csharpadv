using Exercise.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Entities
{
    public class Tester : Employee, ITester
    {
        public void PrintInfo()
        {
            Console.WriteLine($"Description: {FullName} {Age} {Role}");
        }

        public void Test(int numberOfBugs)
        {
            Console.WriteLine($"Testing {numberOfBugs} bugs.");
        }
    }
}
