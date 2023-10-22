namespace P04WeatherForecastAPI.Client.Models
{
    public class ManyDaysForecast
    {
        public required DailyForecastHeadline Headline { get; set; }
        public required DailyForecast[] DailyForecasts { get; set; }
    }
}