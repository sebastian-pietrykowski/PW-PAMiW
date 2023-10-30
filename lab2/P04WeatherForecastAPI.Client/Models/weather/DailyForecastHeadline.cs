namespace P04WeatherForecastAPI.Client.Models
{
    public class DailyForecastHeadline
    {
        public string EffectiveDate { get; set; }
        public string EndDate { get; set; }
        public int Severity { get; set; }
        public string Text { get; set; }
    }
}