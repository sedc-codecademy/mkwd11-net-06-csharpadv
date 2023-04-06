using Exercise.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Entities
{
    public class Developer : Employee, IDeveloper
    {
        public int DevSalary { get; set; }

        public string Code()
        {
            return "coding...";
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Description: {FullName} {Age} {Role}");
        }
    }
}
