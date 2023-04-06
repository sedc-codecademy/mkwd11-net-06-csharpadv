using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class EmployeeHelper
    {
        //this method must be called by using the EmployeeHelper class name
        public static void PrintEmployee(Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} lives on address {employee.Address}");
        }

        //this makes Print seem to be a member of the Employee class
        //it can be called by any instance of the Employee class
        public static void Print(this Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} lives on address {employee.Address}");
        }
    }
}
