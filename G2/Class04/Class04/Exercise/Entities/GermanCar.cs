namespace Exercise.Entities
{
    public class GermanCar : Car
    {
        public int MaxSpeed { get; set; }

        public static void PrintGermanCar(int maxSpeed)
        {
            Console.WriteLine($"The this is the german car, with max speed {maxSpeed}");
        }
    }
}
