using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_CompanyCalendar
{
    //Publisher => Publishes (Raises) new event, when an item is added or removed from the calender
    public class Calendar
    {
        public List<CalenderItem> Items { get; set; }

        public Calendar()
        {
            Items = new List<CalenderItem>();
        }

        public delegate void CalenderDelegate(CalenderItem item);

        public event CalenderDelegate Subscribers;

        public void Subscriber(CalenderDelegate subscribeMethod)
        {
            Subscribers += subscribeMethod;
        }

        public void UnSubscriber(CalenderDelegate subscribeMethod)
        {
            Subscribers -= subscribeMethod;
        }

        public void AddCalenderItem(CalenderItem meeting)
        {
            Items.Add(meeting);

            if(Subscribers != null && Subscribers.GetInvocationList().Length > 0)
            {
                Subscribers(meeting);
            } else
            {
                Console.WriteLine("No subscribers");
            }
        }
    }
}
