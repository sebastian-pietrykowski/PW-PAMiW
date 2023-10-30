namespace P04WeatherForecastAPI.Client.Models
{
    public class Temperatures
    {
        public required Metric Minimum { get; set; }
        public required Metric Maximum { get; set; }
    }
}