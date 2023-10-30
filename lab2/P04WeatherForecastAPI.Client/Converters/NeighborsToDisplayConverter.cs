using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using P04WeatherForecastAPI.Client.Models;

namespace P04WeatherForecastAPI.Client.Converters
{
    internal class NeighborsToDisplayConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is City[]) {
                var neighbors = (value as City[]) ?? Array.Empty<City>();
                var neighborNames = neighbors.Select(city => city.LocalizedName).ToArray();
                var neighborsJoined =  string.Join("\n", neighborNames);
                return neighborsJoined;
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {

            throw new NotImplementedException();
        }
    }
}
