using Exercise.Entities.Enums;
using Exercise.Entities.Interfaces;

namespace Exercise.Entities
{
    public abstract class Car : ICar
    {
        public string Brand { get; set; } = string.Empty;

        public FuelType FuelType { get; set; }

        public string Model { get; set; } = string.Empty;

        public DateTime YearOfProduction { get; set; }

        public int HorsePower { get; set; }

        public void Drive(string destinationName)
        {
            Console.WriteLine($"Going to {destinationName}");
        }

        public void Radio(string songName)
        {
            Console.WriteLine($"Listening to {songName}");
        }
    }
}
