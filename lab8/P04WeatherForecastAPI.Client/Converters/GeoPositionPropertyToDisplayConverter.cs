using System;
using System.Globalization;
using System.Windows.Data;

namespace P04WeatherForecastAPI.Client.Converters
{
    internal class GeoPositionPropertyToDisplayConverter : IValueConverter
    {
        private const  string _degreeCode = "°";

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double || value is double?) {
                return $"{value}{_degreeCode}";
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            throw new NotImplementedException();
        }
    }
}