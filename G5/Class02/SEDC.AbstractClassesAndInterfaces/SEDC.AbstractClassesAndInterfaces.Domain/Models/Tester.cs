using SEDC.AbstractClassesAndInterfaces.Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.AbstractClassesAndInterfaces.Domain.Models
{
    public class Tester : Human, ITester
    {
        public bool IsManualTester { get; set; }
       
        public Tester(string fullName, int age, bool ismanualTester) : base(fullName, age)
        {
            IsManualTester = ismanualTester;
        }

        public override string GetInfo()
        {
            return $"FullName: {FullName} - Age: {Age} = Manual tester: {IsManualTester}";
        }

        public void TestCode()
        {
            Console.WriteLine("Tester test code with Moq..........");
        }
    }
}
