using P04WeatherForecastAPI.Client.Models;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class WeatherViewModel
    {
        public double CurrentTemperature { get; set; }
        public bool HasPrecipitation { get; set;}

        public WeatherViewModel(Weather? weather)
        {
            CurrentTemperature = weather?.Temperature.Metric.Value ?? 0.0;
            HasPrecipitation = weather?.HasPrecipitation ?? false;
        }
    }
}
