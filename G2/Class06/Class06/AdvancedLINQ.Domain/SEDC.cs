using AdvancedLINQ.Domain.Entities;
using AdvancedLINQ.Domain.Enums;

namespace AdvancedLINQ.Domain
{
    public static class SEDC
    {
        public static List<Student> Students = new List<Student>()
        {
            new Student(12, "Bob","Bobsky",23,true),
            new Student(13, "Jill","Wayne",43,false),
            new Student(14, "Greg","Gregsky",23,false),
            new Student(15, "Anne","Wilson",35,true),
            new Student(16, "Liana","Wurtz",34,false),
            new Student(17, "Bill","Zu",18,true)
        };

        public static List<Subject> Subjects = new List<Subject>()
        {
            new Subject(21,"C# Basic",10,24,AcademyType.Programming),
            new Subject(22,"C# Advanced",15,12,AcademyType.Programming),
            new Subject(23,"HTML",10,12,AcademyType.Programming),
            new Subject(24,"CSS",10,24,AcademyType.Programming),
            new Subject(25,"Selenium",12,15,AcademyType.Qa),
            new Subject(26,"Photoshop",7,25,AcademyType.Design),
            new Subject(27,"Illustrator",8,25,AcademyType.Design),
            new Subject(28,"Networks Basics",12,10,AcademyType.Networks),
            new Subject(29,"Networks Advanced",15,5,AcademyType.Networks),
        };

        static SEDC()
        {
            Students[0].Subjects = new List<Subject>() { Subjects[0], Subjects[2], Subjects[3], Subjects[4] };
            Students[1].Subjects = new List<Subject>() { Subjects[3], Subjects[4], Subjects[7] };
            Students[2].Subjects = new List<Subject>() { Subjects[5], Subjects[6] };
            Students[3].Subjects = new List<Subject>() { Subjects[3], Subjects[4], Subjects[7] };
            Students[4].Subjects = new List<Subject>() { Subjects[0], Subjects[2], Subjects[3], Subjects[5], Subjects[6], Subjects[6] };
            Students[5].Subjects = new List<Subject>() { Subjects[2] };
        }
    }
}
