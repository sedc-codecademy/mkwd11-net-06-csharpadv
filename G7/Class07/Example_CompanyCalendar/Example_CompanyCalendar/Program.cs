namespace Example_CompanyCalendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendar seavusCalendar = new Calendar();

            Calendar sedcCalendar = new Calendar();

            Employee e1 = new Employee("Employee 1", "Seavus123");
            Employee e2 = new Employee("Employee 2", "Seavus124");
            Employee e3 = new Employee("Employee 3", "Seavus125");

            Student s1 = new Student("Student 1", "WD");
            Student s2 = new Student("Student 2", "WD");
            Student s3 = new Student("Student 3", "QA");

            seavusCalendar.Subscriber(e1.CalenderItemAddEvent);
            seavusCalendar.Subscriber(e3.CalenderItemAddEvent);
            seavusCalendar.Subscriber(s1.StudentCalenderItemAddEvent);

            sedcCalendar.Subscriber(s1.StudentCalenderItemAddEvent);
            sedcCalendar.Subscriber(s2.StudentCalenderItemAddEvent);
            sedcCalendar.Subscriber(s3.StudentCalenderItemAddEvent);

            CalenderItem i1 = new CalenderItem("Meeting regarding Architecture", DateTime.Now.AddMinutes(-100));
            CalenderItem i2 = new CalenderItem("Sprint Planing", DateTime.Now.AddDays(2).AddHours(-5));

            CalenderItem sedcItem1 = new CalenderItem("Delegates & Events", new DateTime(2023, 4, 18, 17, 30, 00));
            CalenderItem sedcItem2 = new CalenderItem("Workshop", new DateTime(2023, 4, 20, 17, 30, 00));

            seavusCalendar.AddCalenderItem(i1);
            sedcCalendar.AddCalenderItem(sedcItem1);
            seavusCalendar.AddCalenderItem(i2);
            sedcCalendar.UnSubscriber(s3.StudentCalenderItemAddEvent);
            sedcCalendar.AddCalenderItem(sedcItem2);
        }
    }
}