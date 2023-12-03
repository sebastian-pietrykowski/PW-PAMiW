using System;
using System.Globalization;
using System.Windows.Data;
using P04WeatherForecastAPI.Client.ViewModels;

namespace P04WeatherForecastAPI.Client.Converters
{
    internal class TimeZoneToDisplayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is TimeZoneViewModel) {
                var timeZone = value as TimeZoneViewModel;
                return $"{timeZone?.GmtOffset} {timeZone?.Name}";
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            throw new NotImplementedException();
        }
    }
}