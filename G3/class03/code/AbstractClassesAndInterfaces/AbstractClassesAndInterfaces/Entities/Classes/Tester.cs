using AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Entities.Classes
{
    public class Tester : Human, ITester
    {
        public int BugsFound { get; set; }

        public Tester(string fullname,
                      int age, long phone,
                      int bugs) : base(fullname, age, phone)
        {
            BugsFound = bugs;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - found {BugsFound} bugs to date!";
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine($"{feature} is being tested...");
            Console.WriteLine("Testing complete!");
        }
    }
}
