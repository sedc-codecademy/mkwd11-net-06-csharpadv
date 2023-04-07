using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Entities
{
    public abstract class Employee
    {
        public string FullName { get; set; }

        public int Age { get; set; }

        public Role Role { get; set; }

        public Employee()
        {

        }
    }

    public enum Role
    {
        Developer = 1,
        Tester
    }
}
