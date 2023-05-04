using Models;
using Services;
using Services.Abstractions;

namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IWeatherService weatherService = new WeatherService();

                while (true)
                {
                    Console.WriteLine("Weather App!");
                    Console.Write("City: ");
                    string input = Console.ReadLine();

                    WeatherInfo result = weatherService.GetWeatherInfo(input).Result;
                    Console.WriteLine(result.GetInfo());
                }
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error happend, please try again");
            }
        }
    }
}