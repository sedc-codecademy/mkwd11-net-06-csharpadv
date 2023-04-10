namespace SEDC.Class06.Domain.Entities
{
    public class Student : BaseEntity
    {
        public Student(int id, string firstName, string lastName, int age, bool isPartTime)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IsPartTime = isPartTime;
        }

        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }
        public List<Subject> Subjects { get; set; } = new List<Subject>();

        public override string Info()
        {
            string message = $"{Id}) {FirstName} {LastName} - {Age} years old.";
            message += IsPartTime ? " A part time student!" : "";
            return message;
        }
    }
}
