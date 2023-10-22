using System;
using P04WeatherForecastAPI.Client.Models;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class ManyDaysForecastViewModel
    {
        public DailyForecast[] DailyForecasts { get; set; }

        public ManyDaysForecastViewModel(ManyDaysForecast? forecast)
        {
            DailyForecasts = forecast?.DailyForecasts ?? Array.Empty<DailyForecast>();
        }
    }
}
