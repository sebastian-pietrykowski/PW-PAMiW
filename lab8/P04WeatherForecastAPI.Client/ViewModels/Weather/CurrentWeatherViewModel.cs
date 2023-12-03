using P04WeatherForecastAPI.Client.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class CurrentWeatherViewModel : ObservableObject
    {
        public double CurrentTemperature { get; set; }
        public bool HasPrecipitation { get; set;}

        public CurrentWeatherViewModel(Weather weather)
        {
            CurrentTemperature = weather.Temperature.Metric.Value;
            HasPrecipitation = weather.HasPrecipitation;
        }
    }
}