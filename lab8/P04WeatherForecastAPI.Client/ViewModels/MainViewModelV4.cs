using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using P04WeatherForecastAPI.Client.Commands;
using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services.WeatherServices;
using System;
using System.Collections.ObjectModel;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    // przekazywanie wartosci do innego formularza 
    public partial class MainViewModelV4 : ObservableObject
    {
        private CityViewModel _selectedCity;
        private Weather _weather;
        private readonly IAccuWeatherService _accuWeatherService;

        //favorite city 
        private readonly FavoriteCitiesView _favoriteCitiesView;
        private readonly FavoriteCityViewModel _favoriteCityViewModel;
        //public ICommand LoadCitiesCommand { get;  }
        private readonly IServiceProvider _serviceProvider;

       

        public MainViewModelV4(IAccuWeatherService accuWeatherService, 
            FavoriteCityViewModel favoriteCityViewModel, FavoriteCitiesView favoriteCitiesView,
            IServiceProvider serviceProvider)
        {
            _favoriteCitiesView = favoriteCitiesView;
            _favoriteCityViewModel = favoriteCityViewModel;

            _serviceProvider = serviceProvider;

                // _serviceProvider= serviceProvider; 
                //LoadCitiesCommand = new RelayCommand(x => LoadCities(x as string));
                _accuWeatherService = accuWeatherService;
            Cities = new ObservableCollection<CityViewModel>(); // podejście nr 2 


        }

        [ObservableProperty]
        private CurrentWeatherViewModel currentWeatherView;


        public CityViewModel SelectedCity
        {
            get => _selectedCity;
            set
            {
                _selectedCity = value;
                OnPropertyChanged();
                LoadWeather();
            }
        }

         
        private async void LoadWeather()
        {
            if(SelectedCity != null)
            {
                _weather = await _accuWeatherService.GetCurrentConditions(SelectedCity.Key);
                CurrentWeatherView = new CurrentWeatherViewModel(_weather);
            }
        } 

        // podajście nr 2 do przechowywania kolekcji obiektów:
        public ObservableCollection<CityViewModel> Cities { get; set; }

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
        public void OpenFavotireCities()
        {
            //var favoriteCitiesView = new FavoriteCitiesView();
            _favoriteCityViewModel.SelectedCity = new FavoriteCity() { Name = "Warsaw" };
            _favoriteCitiesView.Show();
        }

        [RelayCommand]
        public void OpenWeatherWindow()
        {
            try
            {
                WeatherView weatherView = _serviceProvider.GetService<WeatherView>();
                WeatherViewModel weatherViewModel = _serviceProvider.GetService<WeatherViewModel>();

                weatherView.Show();
            }
            catch (Exception ex)
            {
                // Log the exception or show a message to the user
                System.Windows.MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        [RelayCommand]
        public void OpenMoviesLibraryWindow()
        {
            try
            {
                LibraryMoviesView libraryMoviesView = _serviceProvider.GetService<LibraryMoviesView>();
                MoviesViewModel moviesViewModel = _serviceProvider.GetService<MoviesViewModel>();

                libraryMoviesView.Show();
            }
            catch (Exception ex)
            {
                // Log the exception or show a message to the user
                System.Windows.MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
