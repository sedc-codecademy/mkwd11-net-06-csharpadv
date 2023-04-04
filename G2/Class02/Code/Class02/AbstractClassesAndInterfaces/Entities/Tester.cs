using AbstractClassesAndInterfaces.Entities.Interfaces;

namespace AbstractClassesAndInterfaces.Entities
{
    public class Tester : Human, ITester
    {
        public int BugsFound { get; set; }

        public Tester(string fullName, int age, long phone, int bugsFound) : base(fullName, age, phone)
        {
            BugsFound = bugsFound;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {BugsFound} bugs were found!!!";
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine("Testing some software");
            Console.WriteLine("Oh I found a bug");
            BugsFound++;
        }
    }
}
