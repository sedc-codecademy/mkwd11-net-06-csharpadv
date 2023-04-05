using AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Entities.Classes
{
    public class Developer : Human, IDeveloper
    {
        public List<string> ProgrammingLanguages { get; set; }
        public int YearsOfExperience { get; set; }

        public Developer(string fullname, 
                        int age, long phone, 
                        List<string> languages, 
                        int experience) : base(fullname, age, phone)
        {
            ProgrammingLanguages = languages;
            YearsOfExperience = experience;
        }

        public void Code()
        {
            throw new NotImplementedException();
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {YearsOfExperience} years of experience";
        }
    }
}
