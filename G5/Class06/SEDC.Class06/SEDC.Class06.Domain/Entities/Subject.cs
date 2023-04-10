using SEDC.Class06.Domain.Enums;

namespace SEDC.Class06.Domain.Entities
{
    public class Subject : BaseEntity
    {
        public Subject(int id, string title, int modules, int studentsAttending, Academy type)
        {
            Id = id;
            Title = title;
            Modules = modules;
            StudentsAttending = studentsAttending;
            Type = type;
        }

        public string Title { get; set; }
        public int Modules { get; set; }
        public int StudentsAttending { get; set; }
        public Academy Type { get; set; }

        public override string Info()
        {
            return $"{Id}) {Title} of the {Type} Academy - {StudentsAttending} attending!";
        }
    }
}
