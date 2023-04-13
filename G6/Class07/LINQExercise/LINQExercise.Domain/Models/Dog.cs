using LINQExercise.Domain.Enums;

namespace LINQExercise.Domain.Models
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public Breed Breed { get; set; }

        public Dog(string name, string color, int age, Breed breed)
        {
            Name = name;
            Age = age;
            Color = color;
            Breed = breed;
        }
    }
}
