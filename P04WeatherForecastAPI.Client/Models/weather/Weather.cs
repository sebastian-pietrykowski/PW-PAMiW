using Microsoft.VisualBasic;

namespace P04WeatherForecastAPI.Client.Models
{
    public class Weather
    {
        public required int EpochTime { get; set; }
        public required string WeatherText { get; set; }
        public required int WeatherIcon { get; set; }
        public required bool HasPrecipitation { get; set; }
        public required object PrecipitationType { get; set; }
        public required bool IsDayTime { get; set; }
        public required Temperature Temperature { get; set; }
        public required string MobileLink { get; set; }
        public required string Link { get; set; }
    }
}
