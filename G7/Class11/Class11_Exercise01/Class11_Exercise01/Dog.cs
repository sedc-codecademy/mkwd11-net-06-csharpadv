namespace Class11_Exercise01
{
    public class Dog : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public override string GetInfo()
        {
            return $"{Name} [{Age}] - {Color}";
        }
    }
}
