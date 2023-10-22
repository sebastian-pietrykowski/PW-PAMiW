namespace P04WeatherForecastAPI.Client.Models
{
    public class City
    {
        public required int Version { get; set; }
        public required string Key { get; set; }
        public required string Type { get; set; }
        public required int Rank { get; set; }
        public required string LocalizedName { get; set; }
        public required Country Country { get; set; }
        public required AdministrativeArea AdministrativeArea { get; set; }
        public required string PrimaryPostalCode { get; set; }
        public required GeoPosition GeoPosition { get; set; }
        public required TimeZoneModel TimeZone { get; set; }
    }
}
