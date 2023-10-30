namespace P04WeatherForecastAPI.Client.Models
{
    public class DailyForecast
    {
        public string Date { get; set; }
        public Temperatures Temperature { get; set; }
    }
}