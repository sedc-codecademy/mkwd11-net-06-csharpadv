using AbstractClassesAndInterfaces.Entities.Interfaces;

namespace AbstractClassesAndInterfaces.Entities
{
    public class Developer : Human, IDeveloper
    {
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();

        public int YearsOfExperience { get; set; }

        public Developer(string fullName, int age, long phone, List<string> languages, int experience) : base(fullName, age, phone)
        {
            ProgrammingLanguages = languages;
            YearsOfExperience = experience;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {YearsOfExperience} years of experience!";
        }

        public void Code()
        {
            Console.WriteLine("shtrak shtrak shtraaaak!!!!");
            Console.WriteLine("Opens chatGPT");
            Console.WriteLine("Can not find a solution");
            Console.WriteLine("*cries*");
        }
    }
}
