using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        private int _salary { get; set; }

        public int GetSalary()
        {
            return _salary + 500;
        }

        public void SetSalary(int salary)
        {
            _salary = salary;
        }
    }
}
