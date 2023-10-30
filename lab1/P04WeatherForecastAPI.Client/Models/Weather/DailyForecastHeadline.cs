namespace P04WeatherForecastAPI.Client.Models
{
    public class DailyForecastHeadline
    {
        public required string EffectiveDate { get; set; }
        public required string EndDate { get; set; }
        public required int Severity { get; set; }
        public required string Text { get; set; }
    }
}