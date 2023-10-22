namespace P04WeatherForecastAPI.Client.Models
{
    public class DailyForecast
    {
        public required string Date { get; set; }
        public required Temperatures Temperature { get; set; }
    }
}