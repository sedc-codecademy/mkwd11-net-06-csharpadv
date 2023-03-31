using AbstractClassesAndInterfaces.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Domain.Models
{
    public class Developer : Person, IDeveloper
    {
        public string ProjectName;
        public int YearsOfExperience;
        public List<string> ProgrammingLanguages;

        public Developer(string fullName, int age, 
            string address, long phoneNumber, string projectName, int years, List<string> languages) 
            : base(fullName, age, address, phoneNumber)
        {
            ProjectName = projectName;
            YearsOfExperience = years;
            ProgrammingLanguages = languages == null ? new List<string>() : languages;
        }

        //this method must be present because of IDeveloper interface
        public void Code()
        {
            Console.WriteLine("Coding... \n");
            if(ProgrammingLanguages.Count > 0)
            {
                foreach(string  language in ProgrammingLanguages)
                {
                    Console.WriteLine($"Programmin in {language}");
                }
            }
        }

        //this method MUST be present 
        public override string GetProfessionalInfo()
        {
            return $"{FullName} works as developer for {YearsOfExperience} now. {FullName} works on {ProjectName}";
        }
    }
}
