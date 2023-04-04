using SEDC.Class02.Exercises1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class02.Exercises1.Entities
{
    public class Student : User, IStudent
    {
        public Student(int id, string name, string userName, string password, List<int> grades) 
            : base(id, name, userName, password)
        {
            Grades = grades;
        }


        public List<int> Grades { get; set; }

        public override void PrintUser()
        {
            base.PrintUser();
            foreach ( var grade in Grades )
            {
                Console.WriteLine(grade);
            }
        }
    }
}
