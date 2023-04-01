namespace SEDC.AbstractClasses.Entities
{
    public class Manager : Person
    {
        public string Department { get; set; }

        // We send the id, fName and lName parameters to the base (parent) constructor
        // They will be initialized in the Person constructor
        // Depratment will be initialized in the Manager constructor
        public Manager(int id, string fName, string lName, string department) 
            : base(id, fName, lName)
        {
            Department = department;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} is manager of {Department}");
        }
    }
}
