namespace SEDC.AbstractClasses.Entities
{
    public class Employee : Person
    {
        public int WorkingHours { get; set; } 

        public Employee(int id, string fName, string lName, int workingHours)
            : base(id, fName, lName)
        {
            WorkingHours = workingHours;
        }


        public override void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} | Working hours: {WorkingHours}");
        }
    }
}
