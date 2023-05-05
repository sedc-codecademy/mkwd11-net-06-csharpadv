using Models;

namespace Services.Abstractions
{
    public interface IWeatherService
    {
        Task<WeatherInfo> GetWeatherInfo(string city);
    }
}
