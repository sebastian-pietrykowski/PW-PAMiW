namespace P04WeatherForecastAPI.Client.Models
{
    public class City
    {
        public int Version { get; set; }
        public string Key { get; set; }
        public string Type { get; set; }
        public int Rank { get; set; }
        public string LocalizedName { get; set; }
        public Country Country { get; set; }
        public AdministrativeArea AdministrativeArea { get; set; }
        public string PrimaryPostalCode { get; set; }
        public GeoPosition GeoPosition { get; set; }
        public TimeZoneModel TimeZone { get; set; }
    }
}
