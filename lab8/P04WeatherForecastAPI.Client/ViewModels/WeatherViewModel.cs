using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.MovieCollection;
using P06Shop.Shared.Services.MovieService;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using P04WeatherForecastAPI.Client.Services.WeatherServices;
using P04WeatherForecastAPI.Client.Models;
using System.Linq;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class WeatherViewModel : ObservableObject {
        public ObservableCollection<CityViewModel> Cities { get; set; }

        private CityViewModel _selectedCity;
        
        private readonly IAccuWeatherService _accuWeatherService;
        private readonly FavoriteCitiesView _favoriteCitiesView;
        private readonly FavoriteCityViewModel _favoriteCityViewModel;

        [ObservableProperty]
        private CurrentWeatherViewModel currentWeatherView;

        [ObservableProperty]
        private NeighborsViewModel neighborsView;

        [ObservableProperty]
        private GeoPositonViewModel geoPositionView;

        [ObservableProperty]
        private TimeZoneViewModel timeZoneView;

        [ObservableProperty]
        private AdministrativeAreaViewModel administrativeAreaView;

        [ObservableProperty]
        private ManyDaysForecastViewModel manyDaysForecastView;

        [ObservableProperty]
        private ManyHoursForecastViewModel manyHoursForecastView;


        public WeatherViewModel(IAccuWeatherService accuWeatherService, FavoriteCityViewModel favoriteCityViewModel, FavoriteCitiesView favoriteCitiesView)
        {
            _favoriteCitiesView = favoriteCitiesView;
            _favoriteCityViewModel = favoriteCityViewModel;
            _accuWeatherService = accuWeatherService;
            Cities = new ObservableCollection<CityViewModel>(); // podejście nr 2 
        }

        public CityViewModel SelectedCity
        {
            get => _selectedCity;
            set
            {
                _selectedCity = value;
                OnPropertyChanged();
                LoadContentForCity();
            }
        }

        [RelayCommand]
        public async void LoadCities(string locationName)
        {
            // podejście nr 2:
            var cities = await _accuWeatherService.GetLocations(locationName);
            Cities.Clear();
            foreach (var city in cities) 
                Cities.Add(new CityViewModel(city));
        }

        [RelayCommand]
        public void OpenFavoriteCities()
        {
            //var favoriteCitiesView = new FavoriteCitiesView();
            // _favoriteCityViewModel.SelectedCity = new FavoriteCity() { Name = "Warsaw" };
            _favoriteCitiesView.Show();
        }


        private async void LoadContentForCity()
        {
            if(SelectedCity != null)
            {
                await Task.WhenAll(
                        SetWeatherAndCityName(),
                        SetNeighbors(),
                        SetGeoPosition(),
                        SetTimeZone(),
                        SetAdministrativeArea(),
                        SetFiveDaysDailyForecast(),
                        SetSixHoursHourlyForecast()
                    );
            }
        }

        private async Task SetWeatherAndCityName() {
            var weather = await _accuWeatherService.GetCurrentConditions(SelectedCity.Key); 
            CurrentWeatherView = new CurrentWeatherViewModel(weather);
        }

         private async Task SetNeighbors() {
            var neighbors = await _accuWeatherService.GetNeighbors(SelectedCity.Key);
            var neighborNames = neighbors.Select(city => city.LocalizedName).ToArray();
            var neighborsJoined =  string.Join("\n", neighborNames);
            NeighborsView = new NeighborsViewModel(neighbors);
        }

        private async Task SetGeoPosition() {
            var geoPosition = await _accuWeatherService.GetGeoPosition(SelectedCity.Key);
            GeoPositionView = new GeoPositonViewModel(geoPosition);
        }

         private async Task SetTimeZone() {
            var timeZone = await _accuWeatherService.GetTimeZone(SelectedCity.LocalizedName);
            TimeZoneView = new TimeZoneViewModel(timeZone);
        }

        private async Task SetAdministrativeArea() {
            var administrativeArea = await _accuWeatherService.GetAdministrativeArea(SelectedCity.LocalizedName);
            AdministrativeAreaView = new AdministrativeAreaViewModel(administrativeArea);
        }

        private async Task SetFiveDaysDailyForecast() {
            var fiveDaysDailyForecastCollection = await _accuWeatherService.GetFiveDaysDailyForecast(SelectedCity.Key);
            ManyDaysForecastView = new ManyDaysForecastViewModel(fiveDaysDailyForecastCollection);
        }

        private async Task SetSixHoursHourlyForecast() {
            HourlyForecast[] hourlyForecasts = await _accuWeatherService.GetSixHoursHourlyForecast(SelectedCity.Key);
            ManyHoursForecastView = new ManyHoursForecastViewModel(hourlyForecasts);
        }
    }

}