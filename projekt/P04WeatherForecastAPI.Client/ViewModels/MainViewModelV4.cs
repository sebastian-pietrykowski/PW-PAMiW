using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.DependencyInjection;
using P04WeatherForecastAPI.Client.Commands;
using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services.WeatherServices;
using System;
using System.Collections.ObjectModel;
using P04Library.Client;

using System.Reflection;

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

        //[ObservableProperty]
        //private WeatherViewModel weatherView;
        //public WeatherViewModel WeatherView { 
        //    get { return weatherView; } 
        //    set { 
        //        weatherView = value;
        //        OnPropertyChanged();
        //    }
        //}
        [ObservableProperty]
        private WeatherViewModel weatherView;


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
                WeatherView = new WeatherViewModel(_weather);
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
        public void OpenMoviesLibraryWindow()
        {
            if (!string.IsNullOrEmpty(LoginViewModel.Token)) {
                try
                {
                    LibraryMoviesView libraryMoviesView = _serviceProvider.GetService<LibraryMoviesView>();
                    MoviesViewModel moviesViewModel = _serviceProvider.GetService<MoviesViewModel>();

                    libraryMoviesView.Show();
                    moviesViewModel.GetMovies();
                }
                catch (Exception ex)
                {
                    // Log the exception or show a message to the user
                    System.Windows.MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                System.Windows.MessageBox.Show("You need to login first");
            }            
        }

        [RelayCommand]
        public void OpenLoginWindow()
        {
            LoginView loginView = _serviceProvider.GetService<LoginView>();
            LoginViewModel loginViewModel = _serviceProvider.GetService<LoginViewModel>();

            loginView.Show();
             
        }

        [RelayCommand]
        public void Logout()
        {
            LoginViewModel loginViewModel = _serviceProvider.GetService<LoginViewModel>();
            if (loginViewModel.IsLoggedIn) {
                loginViewModel.Logout();
                System.Windows.MessageBox.Show("Logged out");

            }
        }

        [RelayCommand]
        public void SwitchTheme()
        {
            AppUserSettings.SwitchTheme();
            RefreshAllProperties();
        }

        public void RefreshAllProperties()
        {
            OnPropertyChanged();
            var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (var property in properties)
            {
                OnPropertyChanged(property.Name);
            }
        }

        public bool IsLoggedIn {
            get
            {
                LoginViewModel loginViewModel = _serviceProvider.GetService<LoginViewModel>();
                return loginViewModel.IsLoggedIn;
            }
        }
    }
}
