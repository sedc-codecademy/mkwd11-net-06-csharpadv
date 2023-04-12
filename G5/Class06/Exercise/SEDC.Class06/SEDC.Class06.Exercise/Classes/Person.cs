using SEDC.Class06.Exercise.Enums;

namespace SEDC.Class06.Exercise.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Occupation { get; set; }
        public List<Dog> Dogs { get; set; } = new List<Dog>();

        public Person(string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
            Dogs = new List<Dog>();
        }
    }
}
