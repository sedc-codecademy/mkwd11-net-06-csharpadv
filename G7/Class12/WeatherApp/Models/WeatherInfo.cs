using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Models
{
    public class WeatherInfo
    {
        //[JsonProperty("temperature")]
        public string Temperature { get; set; }
        [JsonProperty("wind")]
        public string WindInKmPerHour { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("forecast")]
        public List<DayWeatherInfo> Forecast { get; set; }

        public string GetInfo()
        {
            string threeDaysTemp = string.Join(", ", Forecast.Select(x => x.Temperature));
            return $"Temperature: {Temperature}\nWind: {WindInKmPerHour}\nDescription: {Description}\nNext days weather: {threeDaysTemp}";
        }
    }
}