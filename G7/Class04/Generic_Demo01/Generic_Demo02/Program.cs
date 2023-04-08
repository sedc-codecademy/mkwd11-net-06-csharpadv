namespace Generic_Demo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                FirstName = "Risto",
                LastName = "Panchevski",
                DateOfBirth = new DateTime(1989, 7, 20)
            };

            Dog d = new Dog()
            {
                Name = "Lucy",
                DateOfBirth = new DateTime(2019, 3, 10)
            };

            Cat c = new Cat()
            {
                Color = "Brown",
                DateOfBirth = new DateTime(2020, 1, 1)
            };

            int pYears = Helper<Person>.CalculateAge(p);
            int dYears = Helper<Dog>.CalculateAge(d);
            int cYears = Helper<Cat>.CalculateAge(c);

            Console.WriteLine($"Person years: {pYears}");
            Console.WriteLine($"Dog years: {dYears}");
            Console.WriteLine($"Cat years: {cYears}");
        }
    }
}