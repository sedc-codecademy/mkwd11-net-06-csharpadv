using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_CompanyCalendar
{
    public class Student
    {
        public string Name { get; set; }

        public string Academy { get; set; }

        public Student(string name, string academy)
        {
            Name = name;
            Academy = academy;
        }

        public void StudentCalenderItemAddEvent(CalenderItem item)
        {
            Console.WriteLine($"{Name}, I have recevie an event that new class is added to my Academy calender {item.Title} - {item.Date.ToString("dd.MM.yyyy")}");
        }
    }
}
