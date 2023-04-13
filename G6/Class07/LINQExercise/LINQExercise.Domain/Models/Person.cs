using LINQExercise.Domain.Enums;

namespace LINQExercise.Domain.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Job { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastName, int age, Job job)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Job = job;
            Dogs = new List<Dog>();
        }
    }
}
