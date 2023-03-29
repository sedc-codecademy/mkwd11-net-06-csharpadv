using SEDC.AbstractClassesAndInterfaces.Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.AbstractClassesAndInterfaces.Domain.Models
{
    public class FullStackDeveloper : Human, IFullStackDeveloper
    {
        public List<string> Frontend { get; set; }
        public List<string> Backend { get; set; }
        public FullStackDeveloper(string fullName, int age, List<string> frontend, List<string> backend) : base(fullName, age)
        {
            Frontend = frontend;
            Backend = backend;
        }

        public override string GetInfo()
        {
            return $"{FullName} - {Age}";
        }

        public void DesignCode()
        {
            Console.WriteLine($"Full stack Developer desing code.........");
        }

        public void Code()
        {
            Console.WriteLine("Full stack Developer is coding........");
        }

        public void TestCode()
        {
            Console.WriteLine("Full stack Developer is testing........");
        }

        public void PrintFrontend()
        {
            Console.WriteLine("==== Frontend App =====");
            foreach(var frontend in Frontend)
            {
                Console.WriteLine(frontend);
            }
        }
        public void PrintBackend()
        {
            Console.WriteLine("==== Frontend App =====");
            foreach (var backend in Backend)
            {
                Console.WriteLine(backend);
            }
        }
    }
}
