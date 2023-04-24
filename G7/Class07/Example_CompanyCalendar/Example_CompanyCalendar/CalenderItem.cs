using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_CompanyCalendar
{
    public class CalenderItem
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public CalenderItem(string title, DateTime date)
        {
            Title = title;
            Date = date;
        }
    }
}
