using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Exercises.Models
{
    public class Human
    {
        public Human(string fName, string lName, int age)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} - {Age}");
        }
    }
}
