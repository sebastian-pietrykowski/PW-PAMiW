namespace P04WeatherForecastAPI.Client.Models
{
    internal class TimeZoneModel
{
        public required string Code { get; set; }
        public required string Name { get; set; }
        public required float GmtOffset { get; set; }
    }
}