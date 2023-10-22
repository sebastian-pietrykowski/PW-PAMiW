namespace P04WeatherForecastAPI.Client.Models
{
    internal class DailyForecast
    {
        public required string Date { get; set; }
        public required Temperatures Temperature { get; set; }
    }
}