using Models;

namespace Class02_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher(1, "Risto", "risto", "test123", new List<string> { "C# Basic", "C# Advance" });
            Teacher t2 = new Teacher(2, "Tijana", "tijana", "123456", new List<string> { "C# Basic", "C# Advance", "MVC" });

            Student s1 = new Student(3, "Christos", "christos", "asd***", new List<int> { 10, 10, 9, 10 });
            Student s2 = new Student(4, "Marko", "marko", "aseeda", new List<int> { 8, 8, 10, 10 });

            Console.WriteLine(t1.PrintUser());
            Console.WriteLine(t2.PrintUser());
            Console.WriteLine(s1.PrintUser());
            Console.WriteLine(s2.PrintUser());

            //Boxing => converting the variable from the child type to its parent type
            User u1 = (User)t1;
            //Console.WriteLine(u1.Subjects);
            Console.WriteLine(t1.Subjects[0]);

            Console.WriteLine(u1.PrintUser());

            //Unboxing => converting a parent type to its orginal child type
            Teacher t1_1 = (Teacher)u1;
            Console.WriteLine(t1_1.PrintUser());
        }
    }
}