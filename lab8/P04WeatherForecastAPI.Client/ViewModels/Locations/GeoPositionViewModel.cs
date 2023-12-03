using P04WeatherForecastAPI.Client.Models;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class GeoPositonViewModel
    {
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public GeoPositonViewModel(GeoPosition? geoPosition)
        {
            Latitude = geoPosition?.Latitude;
            Longitude = geoPosition?.Longitude;
        }
    }
}