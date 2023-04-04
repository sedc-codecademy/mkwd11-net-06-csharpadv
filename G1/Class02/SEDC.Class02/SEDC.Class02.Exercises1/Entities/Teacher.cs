using SEDC.Class02.Exercises1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class02.Exercises1.Entities
{
    public class Teacher : User, ITeacher
    {
        public Teacher(int id, string name, string userName, string password, string subject)
            : base(id, name, userName, password)
        {
            Subject = subject;
        }

        public string Subject { get; set; }

        public override void PrintUser()
        {
            base.PrintUser();
            Console.WriteLine(Subject);
        }
    }
}
