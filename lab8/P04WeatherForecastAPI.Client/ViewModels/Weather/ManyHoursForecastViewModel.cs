using System;
using P04WeatherForecastAPI.Client.Models;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class ManyHoursForecastViewModel
    {
        public HourlyForecast[] HourlyForecasts { get; set; }

        public ManyHoursForecastViewModel(HourlyForecast[] hourlyForecasts)
        {
            HourlyForecasts = hourlyForecasts;
        }
    }
}