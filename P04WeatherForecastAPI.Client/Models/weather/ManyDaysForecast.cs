namespace P04WeatherForecastAPI.Client.Models
{
    internal class ManyDaysForecast
    {
        public required DailyForecastHeadline Headline { get; set; }
        public required DailyForecast[] DailyForecasts { get; set; }
    }
}