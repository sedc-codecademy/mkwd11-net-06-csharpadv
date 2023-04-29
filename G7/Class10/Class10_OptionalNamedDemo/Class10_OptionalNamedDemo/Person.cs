using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class10_OptionalNamedDemo
{
    public class Person
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Person(string name, string role = "Employee")
        {
            Name = name;
            Role = role;
        }
    }
}
