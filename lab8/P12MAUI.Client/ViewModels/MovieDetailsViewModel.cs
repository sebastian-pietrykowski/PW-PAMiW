using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.ApplicationModel;
using P04WeatherForecastAPI.Client.ViewModels;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.MovieCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12MAUI.Client.ViewModels
{
    [QueryProperty(nameof(Movie), nameof(Movie))]
    [QueryProperty(nameof(MovieDetailsViewModel), nameof(MovieDetailsViewModel))]
    public partial class MovieDetailsViewModel : ObservableObject
    {
        private readonly IMovieService _movieService;
        private readonly IMessageDialogService _messageDialogService;
        private readonly IGeolocation _geolocation;
        private readonly IMap _map;
        private MoviesViewModel _moviesViewModel;

        public MovieDetailsViewModel(IMovieService movieService, IMessageDialogService messageDialogService, IGeolocation geolocation, IMap map)
        {
            _movieService = movieService;
            _messageDialogService = messageDialogService;
            _geolocation = geolocation;
            _map = map;
        }


        [RelayCommand]
        public async Task GetLocation()
        {
            var location = await _geolocation.GetLastKnownLocationAsync();

            try
            {
                await _map.OpenAsync(52.23564245654427, 21.0112328246909, new MapLaunchOptions
                {
                    Name = "ALX",
                    NavigationMode = NavigationMode.None
                });
            }
            catch (Exception)
            {
                 _messageDialogService.ShowMessage("Error opening map");
            }
            
        }

        public MoviesViewModel MoviesViewModel
        {
            get
            {
                return _moviesViewModel;
            }
            set
            {
                _moviesViewModel = value;
            }
        }


        [ObservableProperty]
        Movie movie;

        public async Task DeleteMovie()
        {
            await _movieService.DeleteMovieAsync(movie.Id);
            await _moviesViewModel.GetMovies();
        }

        public async Task CreateMovie()
        {
            var newMovie = new Movie()
            {
                Title = movie.Title,
                Description = movie.Description,
                LengthInMinutes = movie.LengthInMinutes,
                ReleaseDate = movie.ReleaseDate,
                CountryOfOrigin = movie.CountryOfOrigin,
                Director = movie.Director,
            };

            var result = await _movieService.CreateMovieAsync(newMovie);
            if (result.Success)
                await _moviesViewModel.GetMovies();
            else
                _messageDialogService.ShowMessage(result.Message);
        }

        public async Task UpdateMovie()
        {
            var movieToUpdate = new Movie()
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                LengthInMinutes = movie.LengthInMinutes,
                ReleaseDate = movie.ReleaseDate,
                CountryOfOrigin = movie.CountryOfOrigin,
                Director = movie.Director,
            };

            await _movieService.UpdateMovieAsync(movieToUpdate);
            await _moviesViewModel.GetMovies();
        }

        [RelayCommand]
        public async Task Save()
        {
            if (movie.Id == 0)
            {
                CreateMovie();
                await Shell.Current.GoToAsync("../", true);

            }
            else
            {
                UpdateMovie();
                await Shell.Current.GoToAsync("../", true);
            }

        }

        [RelayCommand]
        public async Task Delete()
        {
            DeleteMovie();
            await Shell.Current.GoToAsync("../", true);
        }
    }
}
