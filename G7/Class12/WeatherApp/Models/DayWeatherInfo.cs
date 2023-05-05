using Newtonsoft.Json;

namespace Models
{
    public class DayWeatherInfo
    {
        [JsonProperty("day")]
        public int DayFromNow { get; set; }
        [JsonProperty("temperature")]
        public string Temperature { get; set; }
        [JsonProperty("wind")]
        public string Wind { get; set; }
    }
}
