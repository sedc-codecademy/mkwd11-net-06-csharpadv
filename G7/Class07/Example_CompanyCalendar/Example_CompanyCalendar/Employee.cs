using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_CompanyCalendar
{
    public class Employee
    {
        public string Name { get; set; }

        public string CardId { get; set; }

        public Employee(string name, string cardId)
        {
            Name = name;
            CardId = cardId;
        }

        public void CalenderItemAddEvent(CalenderItem item)
        {
            Console.WriteLine($"{Name}, I have recevie an event that new CalenderItem is added to my company calender {item.Title} - {item.Date.ToString("dd.MM.yyyy")}");
        }
    }
}
