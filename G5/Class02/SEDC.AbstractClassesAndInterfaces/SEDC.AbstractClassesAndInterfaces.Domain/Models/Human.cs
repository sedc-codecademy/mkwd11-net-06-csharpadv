using SEDC.AbstractClassesAndInterfaces.Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.AbstractClassesAndInterfaces.Domain.Models
{
    public abstract class Human : IHuman
    {
        public string FullName { get; set; }
        public int Age { get; set; }

        //public abstract long Phone { get; set; }

        public Human(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        public abstract string GetInfo();


        public void Greet(string name)
        {
            Console.WriteLine($"Hey there {name}! My name is {FullName}");
        }
    }
}
