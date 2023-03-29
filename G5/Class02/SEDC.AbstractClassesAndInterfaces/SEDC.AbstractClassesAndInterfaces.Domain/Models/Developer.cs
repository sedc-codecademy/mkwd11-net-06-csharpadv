using SEDC.AbstractClassesAndInterfaces.Domain.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.AbstractClassesAndInterfaces.Domain.Models
{
    public class Developer : Human, IDeveloper 
    {
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();
        public int YearOFExperience { get; set; }
        //public override long Phone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Developer(string fullName, int age, List<string> programmingLanguages, int yearOFExperience) : base(fullName, age)
        {
            ProgrammingLanguages = programmingLanguages;
            YearOFExperience = yearOFExperience;
        }

        public override string GetInfo()
        {
            return $"FullName: {FullName} - Age: {Age} = I am developer with {YearOFExperience} year of experience.";
        }

        public void Code()
        {
            Console.WriteLine("Developer write code ............");
        }
    }
}
