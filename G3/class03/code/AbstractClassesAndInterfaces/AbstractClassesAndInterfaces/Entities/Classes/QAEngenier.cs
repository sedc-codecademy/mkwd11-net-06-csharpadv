using AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Entities.Classes
{
    public class QAEngenier : Human, IDeveloper, ITester
    {
        public List<string> TestingFrameworks { get; set; }

        public QAEngenier(string fullname,
                         int age, long phone,
                         List<string> frameworks) : base(fullname, age, phone)
        {
            TestingFrameworks = frameworks;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - Knows " +
                $"{(TestingFrameworks.Count != 0 ? TestingFrameworks[0] : "unknown")} testing frameworks!";
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("Open StackExchange SQA...");
            Console.WriteLine("tak tak tak tak tak...");
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine("Run Unit Tests...");
            Console.WriteLine("Run Automated Tests...");
            Console.WriteLine($"Tests for the {feature} feature are done!");
        }
    }
}
