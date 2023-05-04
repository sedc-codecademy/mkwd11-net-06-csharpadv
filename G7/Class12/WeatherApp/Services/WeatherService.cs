using Models;
using Newtonsoft.Json;
using Services.Abstractions;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        public async Task<WeatherInfo> GetWeatherInfo(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                throw new ArgumentException("Wrong input for city");
            }

            string baseAddress = "https://goweather.herokuapp.com/";
            string url = $"weather/{city}";

            using (HttpClient client = new HttpClient())
            {
                //client.BaseAddress = new Uri(baseAddress);

                HttpResponseMessage responseMessage = await client.GetAsync(baseAddress + url);

                if (!responseMessage.IsSuccessStatusCode)
                {
                    throw new ArgumentException("The API call did not passed, try again!");
                }

                string content = await responseMessage.Content.ReadAsStringAsync();
                WeatherInfo weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(content);
                return weatherInfo;
            }
        }
    }
}