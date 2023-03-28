using SEDC.AcademyManagement.Domain.Enums;

namespace SEDC.AcademyManagement.Domain.Models
{
    public class Student : AcademyMember
    {
        public Student(string userName, string firstName, string lastName, int age) : base(userName, firstName, lastName, age)
        {
            Role = Role.Student;
        }

        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject, int> Grades { get; set; } = new Dictionary<Subject, int>();

        public void PrintDetails()
        {
            Console.WriteLine($"[{Age}] {FirstName} {LastName} ({UserName})");

            if (CurrentSubject == null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Currently on holiday");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Currently attending {CurrentSubject.Name}");
            }
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine("Grades");

            if (Grades == null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("The student has still no grades");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                foreach (var grade in Grades)
                {
                    Console.WriteLine($"{grade.Key.Name}: {grade.Value}");
                }
            }

            Console.ResetColor();
            Console.WriteLine("===============================");
        }
    }
}
