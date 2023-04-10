using SEDC.Class06.Domain.Entities;
using SEDC.Class06.Domain.Enums;

namespace SEDC.Class06.LINQ.Helpers
{
    public static class AcademyDatabase
    {
        static AcademyDatabase()
        {
            SeedData();
        }

        public static List<Student> Students { get; set; } = new List<Student>();
        public static List<Subject> Subjects { get; set; } = new List<Subject>();

        private static void SeedData()
        {
            Students = new List<Student>()
            {
                new Student(12, "Bob", "Bobsky", 29, false),
                new Student(22, "Jill", "Wayne", 36, true),
                new Student(27, "Greg", "Gregsky", 45, false),
                new Student(29, "Anne", "Willson", 31, true),
                new Student(20, "Anne", "Wayne", 31, true),
                new Student(30, "Liana", "Wurtz", 25, false),
                new Student(41, "Bill", "Zu", 38, false)
            };

            Subjects = new List<Subject>()
            {
                new Subject(15, "C# Basic", 10, 24, Academy.Programming ),
                new Subject(16, "C# Advanced", 15, 26, Academy.Programming ),
                new Subject(44, "JavaScript", 25, 22, Academy.Programming ),
                new Subject(67, "Photoshop", 12, 18, Academy.Design ),
                new Subject(88, "Illustrator", 12, 18, Academy.Design ),
                new Subject(97, "Networks Basic", 8, 12, Academy.Networks ),
                new Subject(98, "Networks Advanced", 16, 10, Academy.Networks )
            };

            Students[0].Subjects = new List<Subject>() { Subjects[0], Subjects[2], Subjects[3], Subjects[4] };
            Students[1].Subjects = new List<Subject>() { Subjects[3], Subjects[4], Subjects[5], Subjects[1] };
            Students[2].Subjects = new List<Subject>() { Subjects[5], Subjects[6] };
            Students[3].Subjects = new List<Subject>() { Subjects[3], Subjects[4] };
            Students[4].Subjects = new List<Subject>() { Subjects[1], Subjects[2], Subjects[3], Subjects[5] };
            Students[5].Subjects = new List<Subject>() { Subjects[2] };
        }
    }
}
