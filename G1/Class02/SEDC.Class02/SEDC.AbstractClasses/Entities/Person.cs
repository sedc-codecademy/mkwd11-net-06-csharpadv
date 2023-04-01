namespace SEDC.AbstractClasses.Entities
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public void GetDescription()
        {
            Console.WriteLine("This is Person class");
        }

        public abstract void GetInfo();


    }
}
