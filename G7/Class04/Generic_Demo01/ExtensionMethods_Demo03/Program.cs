namespace ExtensionMethods_Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1989, 7, 20);

            int age = DateTimeHelper.CalculateAges(date);

            int age1 = date.CalculateAges();

            List<Person> students = new List<Person>
            {
                new Person("Risto", new DateTime(1989, 10, 10)),
                new Person("Tijana", new DateTime(1999, 10, 10)),
                new Person("Frosina", new DateTime(1997, 10, 10)),
                new Person("Marko", new DateTime(1990, 10, 10)),
                new Person("Christos", new DateTime(1991, 10, 10)),
            };

            int sum = 0;
            foreach(Person s in students)
            {
                sum += DateTimeHelper.CalculateAges(s.DateOfBirth);
            }

            Console.WriteLine($"The average is {sum / (double)students.Count}");

            //double average = students.Select(x => DateTimeHelper.CalculateAges(x.DateOfBirth)).Average();
            //Console.WriteLine($"The average is {average}");

            double average = students.Select(x => x.DateOfBirth.CalculateAges()).Average();
            Console.WriteLine($"The average is {average}");


            string title = "some title here";

            Console.WriteLine(title.ToTitleCase());


            //Console.WriteLine(StringHelper.Replicate(StringHelper.ToTitleCase(title), 5));

            Console.WriteLine(title.ToTitleCase().Replicate(5));
        }
    }
}