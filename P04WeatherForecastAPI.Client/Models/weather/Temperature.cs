namespace P04WeatherForecastAPI.Client.Models
{
    internal class Temperature
    {
        public required Metric Metric { get; set; }
        public required Imperial Imperial { get; set; }
    }
}
