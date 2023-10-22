namespace P04WeatherForecastAPI.Client.Models
{
    public class ManyDaysForecast
    {
        public DailyForecastHeadline Headline { get; set; }
        public DailyForecast[] DailyForecasts { get; set; }
    }
}