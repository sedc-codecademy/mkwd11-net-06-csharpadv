using Exercise01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Domain.Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public Student()
        {

        }

        public Student(int id, string name, string username, string password, List<int> grades)
            :base(id, name, username, password)
        {
            Grades = grades != null ? grades : new List<int>();
        }

        public override void PrintUser()
        {
            int averageGrade = Grades.Sum() / Grades.Count();
            Console.WriteLine($"{Username} has average grade {averageGrade}");
        }

        public void PrintGrades()
        {
            Console.WriteLine($"Grades for {Name}:");
            foreach(int grade in Grades)
            {
                Console.Write(grade + " ");
            }
        }
    }
}
