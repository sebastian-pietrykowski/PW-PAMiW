namespace P04WeatherForecastAPI.Client.Models
{
    internal class HourlyForecast
    {
        public required string DateTime { get; set; }
        public required Metric Temperature { get; set; }
    }
}