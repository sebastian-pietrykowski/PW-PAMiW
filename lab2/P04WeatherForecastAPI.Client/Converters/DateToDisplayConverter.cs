using System;
using System.Globalization;
using System.Windows.Data;
using P04WeatherForecastAPI.Client.ViewModels;

namespace P04WeatherForecastAPI.Client.Converters
{
    internal class DateToDisplayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string) {
                var date = value as string;
                if (date == null) return value;
                return date[..10];
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            throw new NotImplementedException();
        }
    }
}
