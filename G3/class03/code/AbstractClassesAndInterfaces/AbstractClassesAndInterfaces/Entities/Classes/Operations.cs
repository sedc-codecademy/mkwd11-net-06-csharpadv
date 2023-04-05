using AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Entities.Classes
{
    public class Operations : Human, IOperations
    {
        public List<string> Projects { get; set; }

        public Operations(string fullname,
                          int age, long phone,
                          List<string> projects) : base(fullname, age, phone)
        {
            Projects = projects;
        }

        public bool CheckInfrastructure(int status)
        {
            if (status.ToString().StartsWith("4")) 
            {
                return false;
            }

            return true;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - Currently working on {Projects.Count} projects!";
        }
    }
}
