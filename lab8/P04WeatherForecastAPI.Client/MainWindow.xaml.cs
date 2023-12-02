using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services;
using P04WeatherForecastAPI.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace P04WeatherForecastAPI.Client
{
    //MVVM

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewModelV4 _viewModel;
        public MainWindow(MainViewModelV4 viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            //accuWeatherService = new AccuWeatherService();
        }

        






        //AccuWeatherService accuWeatherService;
        //IAccuWeatherService _accuWeatherService;
        //public MainWindow(IAccuWeatherService accuWeatherService)
        //{
        //    InitializeComponent();
        //    _accuWeatherService = accuWeatherService;
        //    //accuWeatherService = new AccuWeatherService();
        //}

        //private async void btnSearch_Click(object sender, RoutedEventArgs e)
        //{

        //    City[] cities= await _accuWeatherService.GetLocations(txtCity.Text);

        //    // standardowy sposób dodawania elementów
        //    //lbData.Items.Clear();
        //    //foreach (var c in cities)
        //    //    lbData.Items.Add(c.LocalizedName);

        //    // teraz musimy skorzystac z bindowania danych bo chcemy w naszej kontrolce przechowywac takze id miasta 
        //    lbData.ItemsSource = cities;
        //}

        //private async void lbData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var selectedCity= (City)lbData.SelectedItem;
        //    if(selectedCity != null)
        //    {
        //        var weather = await _accuWeatherService.GetCurrentConditions(selectedCity.Key);
        //        lblCityName.Content = selectedCity.LocalizedName;
        //        double tempValue = weather.Temperature.Metric.Value;
        //        lblTemperatureValue.Content = Convert.ToString(tempValue);
        //    }
        //}
    }
}
