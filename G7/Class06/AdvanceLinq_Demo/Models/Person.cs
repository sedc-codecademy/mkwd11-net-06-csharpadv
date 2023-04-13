using Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public JobEnum Occupation { get; set; }
        public List<Dog> Dogs { get; set; }


        public Person(string firstName, string lastName, int age, JobEnum occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
            Dogs = new List<Dog>();
        }

        public override string GetInfo()
        {
            string text = "------------Person Info-------------------\n";
            text += $"{FirstName} {LastName} - {Age} [{Occupation}]\n";


            text += "------------Dogs-------------------";
            foreach (Dog d in Dogs)
            {
                text += "\n" + d.GetInfo();
            }

            return text;
        }
    }
}
