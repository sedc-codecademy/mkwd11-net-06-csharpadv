using AbstractClassesAndInterfaces.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Domain.Models
{
    public class QAEngineer : Person, IQAEngineer, IDeveloper
    {
        public int NumberOfProjects { get; set; }
        public List<string> TestingFrameworks { get; set; }

        public QAEngineer(string fullName, int age,
            string address, long phoneNumber, int numofProjects, List<string> frameworks) : base(fullName, age, address, phoneNumber)
        {
            NumberOfProjects = numofProjects;
            TestingFrameworks = frameworks != null ? frameworks : new List<string>();
        }

        public override string GetProfessionalInfo()
        {
            string info = $"{FullName} works on {NumberOfProjects} projects";
            if(TestingFrameworks.Count > 0)
            {
                info += $" {FullName} knows the following frameworks: ";

                foreach(string framework in TestingFrameworks)
                {
                    info += $"{framework} \n" ;
                }
            }

            return info;
        }

        public void TestingFeature(string feature, DateTime deadline)
        {
            Console.WriteLine($"Testing feature: {feature}. The deadline is: {deadline}");
        }

        public void Code()
        {
            Console.WriteLine($"{FullName} is QA Engineer, but also works with writing automatic tests");
        }
    }
}
