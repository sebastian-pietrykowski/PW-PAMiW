using P04WeatherForecastAPI.Client.Models;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class TimeZoneViewModel
    {
        public string? Name { get; set; }
        public float? GmtOffset { get; set; }

        public TimeZoneViewModel(TimeZoneModel? timeZone)
        {
            Name = timeZone?.Name;
            GmtOffset = timeZone?.GmtOffset;
        }
    }
}
