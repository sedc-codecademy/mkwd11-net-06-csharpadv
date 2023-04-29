using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdvancedLinq.Entities
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }

        public List<Subject> Subjects { get; set; }

        public Student()
        {          
        }

        public Student(int id, string first, string last, int age, bool partTime)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            Age = age;
            IsPartTime = partTime;
        }

        public override string Info()
        {
            string result = $"{Id}) {FirstName} {LastName} - {Age} years old.";
            result += IsPartTime ? " A part time student!" : "";
            return result;
        }
    }
}
