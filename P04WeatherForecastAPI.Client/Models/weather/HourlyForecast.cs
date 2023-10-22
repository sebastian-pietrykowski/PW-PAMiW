namespace P04WeatherForecastAPI.Client.Models
{
    public class HourlyForecast
    {
        public string DateTime { get; set; }
        public Metric Temperature { get; set; }
    }
}