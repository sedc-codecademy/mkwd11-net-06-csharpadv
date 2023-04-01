using SEDC.AbstractClassesAndInterfaces.Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.AbstractClassesAndInterfaces.Domain.Models
{
    public class QAEngeneer : Human, IDeveloper, ITester
    {
        public List<string> TestProgram { get; set; }
        public QAEngeneer(string fullName, int age, List<string> testProgram) : base(fullName, age)
        {
            TestProgram = testProgram;
        }

        public override string GetInfo()
        {
            return $"FullName: {FullName} - Age: {Age}";
        }

        public void Code()
        {
            Console.WriteLine("== QAEngeneer coding ==");
            Console.WriteLine("Bugs"); 
        }

        public void TestCode()
        {
            Console.WriteLine("==== QAEngeneer testing==");
            Console.WriteLine("Test app");
        }
    }
}
