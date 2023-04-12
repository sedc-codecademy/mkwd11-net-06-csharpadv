using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }
        public int Modules { get; set; }
        public int StudentsAttending { get; set; }
        public Academy Type { get; set; }

        public Subject(int id, string title, int modules, int students, Academy type)
        {
            Id = id;
            Title = title;
            Modules = modules;
            StudentsAttending = students;
            Type = type;
        }
    }
}
