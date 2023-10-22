using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace P04WeatherForecastAPI.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AccuWeatherService accuWeatherService;
        public MainWindow()
        {
            InitializeComponent();
            accuWeatherService = new AccuWeatherService();
        }

        // private async void btnSearch_Click(object sender, RoutedEventArgs e)
        // {
            
        //     City[] cities= await accuWeatherService.GetLocations(txtCity.Text);

        //     // standardowy sposób dodawania elementów
        //     //lbData.Items.Clear();
        //     //foreach (var c in cities)
        //     //    lbData.Items.Add(c.LocalizedName);

        //     // teraz musimy skorzystac z bindowania danych bo chcemy w naszej kontrolce przechowywac takze id miasta 
        //     lbData.ItemsSource = cities;
        // }

        // private async void lbData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        // {
        //     City? selectedCity= (City)lbData.SelectedItem;
        //     if (selectedCity != null) {
        //             await Task.WhenAll(
        //                 SetWeatherAndCityName(selectedCity),
        //                 SetNeighbors(selectedCity),
        //                 SetGeoPosition(selectedCity),
        //                 SetTimeZone(selectedCity),
        //                 SetAdministrativeArea(selectedCity),
        //                 SetFiveDaysDailyForecast(selectedCity),
        //                 SetSixHoursHourlyForecast(selectedCity)
        //             );
        //     }
        // }
        // private async Task SetWeatherAndCityName(City selectedCity) {
        //     var weather = await accuWeatherService.GetCurrentConditions(selectedCity.Key);
        //     lblCityName.Content = selectedCity.LocalizedName;
        //     double? tempValue = weather?.Temperature.Metric.Value;
        //     lblTemperatureValue.Content = Convert.ToString(tempValue) + " °C";
        // }

        // private async Task SetNeighbors(City selectedCity) {
        //     var neighbors = await accuWeatherService.GetNeighbors(selectedCity.Key);
        //     var neighborNames = neighbors.Select(city => city.LocalizedName).ToArray();
        //     lblNeighborsValue.Content = string.Join("\n", neighborNames);
        // }

        // private async Task SetGeoPosition(City selectedCity) {
        //     var geoPosition = await accuWeatherService.GetGeoPosition(selectedCity.Key);
        //     lblGeoPositionLatitudeValue.Content = Convert.ToString(geoPosition?.Latitude) + " °";
        //     lblGeoPositionLongitudeValue.Content = Convert.ToString(geoPosition?.Longitude) + " °";
        // }

        // private async Task SetTimeZone(City selectedCity) {
        //     var timeZone = await accuWeatherService.GetTimeZone(selectedCity.LocalizedName);
        //     lblTimeZoneValue.Content = Convert.ToString(timeZone?.GmtOffset + " " + timeZone?.Name);
        // }

        // private async Task SetAdministrativeArea(City selectedCity) {
        //     var administrativeArea = await accuWeatherService.GetAdministrativeArea(selectedCity.LocalizedName);
        //     lblAdministrativeAreaValue.Content = Convert.ToString(administrativeArea?.LocalizedName);
        // }

        // private async Task SetFiveDaysDailyForecast(City selectedCity) {
        //     var fiveDaysDailyForecastCollection = await accuWeatherService.GetFiveDaysDailyForecast(selectedCity.Key);
        //     if (fiveDaysDailyForecastCollection == null)
        //             return;
        //     DailyForecast[] dailyForecasts = fiveDaysDailyForecastCollection.DailyForecasts;

        //     SetFiveDaysDailyForecastDateLabels(dailyForecasts);
        //     SetFiveDaysDailyForecastMinTempLabels(dailyForecasts);
        //     SetFiveDaysDailyForecastMaxTempLabels(dailyForecasts);
        // }

        // private void SetFiveDaysDailyForecastDateLabels(DailyForecast[] dailyForecasts) {
        //     Label[] dateLabels = {
        //         lbl5DaysDailyForecast1stDayDateValue,
        //         lbl5DaysDailyForecast2ndDayDateValue,
        //         lbl5DaysDailyForecast3rdDayDateValue,
        //         lbl5DaysDailyForecast4thDayDateValue,
        //         lbl5DaysDailyForecast5thDayDateValue
        //     };
        //     for (int i = 0; i < 5; i++) {
        //         dateLabels[i].Content = Convert.ToString(dailyForecasts[i].Date)[..10];
        //     }
        // }

        // private void SetFiveDaysDailyForecastMinTempLabels(DailyForecast[] dailyForecasts) {
        //     Label[] minTempLabels = {
        //         lbl5DaysDailyForecast1stDayMinTempValue,
        //         lbl5DaysDailyForecast2ndDayMinTempValue,
        //         lbl5DaysDailyForecast3rdDayMinTempValue,
        //         lbl5DaysDailyForecast4thDayMinTempValue,
        //         lbl5DaysDailyForecast5thDayMinTempValue
        //     };
        //     for (int i = 0; i < 5; i++) {
        //         var temperature = dailyForecasts[i].Temperature.Minimum;
        //         minTempLabels[i].Content = Convert.ToString(temperature.Value)+ " °" + temperature.Unit;
        //     }
        // }

        // private void SetFiveDaysDailyForecastMaxTempLabels(DailyForecast[] dailyForecasts) {
        //     Label[] maxTempLabels = {
        //         lbl5DaysDailyForecast1stDayMaxTempValue,
        //         lbl5DaysDailyForecast2ndDayMaxTempValue,
        //         lbl5DaysDailyForecast3rdDayMaxTempValue,
        //         lbl5DaysDailyForecast4thDayMaxTempValue,
        //         lbl5DaysDailyForecast5thDayMaxTempValue
        //     };
        //     for (int i = 0; i < 5; i++) {
        //         var temperature = dailyForecasts[i].Temperature.Maximum;
        //         maxTempLabels[i].Content = Convert.ToString(temperature.Value) + " °" + temperature.Unit;
        //     }
        // }

        // private async Task SetSixHoursHourlyForecast(City selectedCity) {
        //     HourlyForecast[] hourlyForecasts = await accuWeatherService.GetSixHoursHourlyForecast(selectedCity.Key);

        //     SetSixHoursHourlyForecastHourLabels(hourlyForecasts);
        //     SetSixHoursHourlyForecastTempLabels(hourlyForecasts);
        // }

        // private void SetSixHoursHourlyForecastHourLabels(HourlyForecast[] hourlyForecasts) {
        //     Label[] dateLabels = {
        //         lbl6HoursHourlyForecast1stHourValue,
        //         lbl6HoursHourlyForecast2ndHourValue,
        //         lbl6HoursHourlyForecast3rdHourValue,
        //         lbl6HoursHourlyForecast4thHourValue,
        //         lbl6HoursHourlyForecast5thHourValue,
        //         lbl6HoursHourlyForecast6thHourValue
        //     };
        //     for (int i = 0; i < 6; i++) {
        //         dateLabels[i].Content = Convert.ToString(hourlyForecasts[i].DateTime).Substring(11, 5);
        //     }
        // }

        // private void SetSixHoursHourlyForecastTempLabels(HourlyForecast[] hourlyForecasts) {
        //     Label[] maxTempLabels = {
        //         lbl6HoursHourlyForecast1stHourTempValue,
        //         lbl6HoursHourlyForecast2ndHourTempValue,
        //         lbl6HoursHourlyForecast3rdHourTempValue,
        //         lbl6HoursHourlyForecast4thHourTempValue,
        //         lbl6HoursHourlyForecast5thHourTempValue,
        //         lbl6HoursHourlyForecast6thHourTempValue
        //     };
        //     for (int i = 0; i < 6; i++) {
        //         var temperature = hourlyForecasts[i].Temperature;
        //         maxTempLabels[i].Content = Convert.ToString(temperature.Value) + " °" + temperature.Unit;
        //     }
        // }
    }
}
