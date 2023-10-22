namespace P04WeatherForecastAPI.Client.Models
{
    public class Temperature
    {
        public required Metric Metric { get; set; }
        public required Imperial Imperial { get; set; }
    }
}
