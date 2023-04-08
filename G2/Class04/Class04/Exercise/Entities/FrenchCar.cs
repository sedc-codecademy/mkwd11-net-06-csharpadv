namespace Exercise.Entities
{
    public class FrenchCar : Car
    {
        public bool Navigation { get; set; }

        public static void PrintFrenchCar(string brand)
        {
            Console.WriteLine($"This is the french car {brand}");
        }
    }
}
