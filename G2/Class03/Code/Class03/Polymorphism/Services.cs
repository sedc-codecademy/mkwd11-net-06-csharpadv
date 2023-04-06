namespace Polymorphism
{
    public class Services
    {
        public static void Eat()
        {
            Console.WriteLine("Eating kebapi.");
        }

        public static void Eat(string food)
        {
            Console.WriteLine($"Eating {food} and also some kebapi.");
        }

        public static void Eat(string food, int kg)
        {
            Console.WriteLine($"Eating {kg} {food} and also some kebapi.");
        }

        public static string Eat(int kg, string food)
        {
            return $"Eating {kg} {food}.";
        }
    }
}
