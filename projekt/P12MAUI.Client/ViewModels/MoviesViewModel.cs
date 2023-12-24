using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P04WeatherForecastAPI.Client.Models;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.MovieCollection;
using P12MAUI.Client;
using P12MAUI.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace P04WeatherForecastAPI.Client.ViewModels
{
   
 public partial class MoviesViewModel : ObservableObject
    {
        private readonly IMovieService _movieService;
        private readonly MovieDetailsView _movieDetailsView;
        private readonly IMessageDialogService _messageDialogService;
        private readonly IConnectivity _connectivity;
        public ObservableCollection<Movie> Movies { get; set; }

        [ObservableProperty]
        private Movie selectedMovie;

        public MoviesViewModel(IMovieService movieService, MovieDetailsView movieDetailsView, IMessageDialogService messageDialogService,
            IConnectivity connectivity)
        {
            _movieService = movieService;
            _movieDetailsView = movieDetailsView;
            _messageDialogService = messageDialogService;
            _connectivity = connectivity; // set the _connectivity field
            Movies = new ObservableCollection<Movie>();
            GetMovies();
        }

        public async Task GetMovies()
        {
            Console.WriteLine("GetMovies 1");

            // Movies.Clear();
            // Movies.Add(new Movie() { Title = "Movie 1", Description = "Description 1", LengthInMinutes = 121, ReleaseDate = DateTime.Now, CountryOfOrigin = "Poland", Director = "Director 1" });
            // Movies.Add(new Movie() { Title = "Movie 2", Description = "Description 2", LengthInMinutes = 122, ReleaseDate = DateTime.Now, CountryOfOrigin = "Poland", Director = "Director 2" });
            // Movies.Add(new Movie() { Title = "Movie 3", Description = "Description 3", LengthInMinutes = 123, ReleaseDate = DateTime.Now, CountryOfOrigin = "Poland", Director = "Director 3" });

            // if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            // {
            //     _messageDialogService.ShowMessage("Internet not available!");
            //     return;
            // }

            Movies.Clear();
            var moviesResult = await _movieService.GetMoviesAsync();
            
            if (moviesResult.Success)
            {
                foreach (var m in moviesResult.Data)
                {
                    Movies.Add(m);
                }
            }

            Console.WriteLine("GetMovies 2");

            // var moviesResult = await _movieService.GetMoviesAsync();
            // if (moviesResult.Success)
            // {
            //     foreach (var m in moviesResult.Data)
            //     {
            //         Movies.Add(m);
            //     }
            // }
            // else
            // {
            //     _messageDialogService.ShowMessage(moviesResult.Message);
            // }
        }

        [RelayCommand]
        public async Task ShowMovieDetails(Movie movie)
        {
            if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                _messageDialogService.ShowMessage("Internet not available!");
                return;
            }

            await Shell.Current.GoToAsync(nameof(MovieDetailsView), true, new Dictionary<string, object>
            {
                {"Movie", movie },
                {nameof(MoviesViewModel), this }
            });
            selectedMovie = movie;
        }

        [RelayCommand]
        public async Task New()
        {
            if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                _messageDialogService.ShowMessage("Internet not available!");
                return;
            }

            selectedMovie = new Movie();
            await Shell.Current.GoToAsync(nameof(MovieDetailsView), true, new Dictionary<string, object>
            {
                {"Movie", selectedMovie },
                {nameof(MoviesViewModel), this }
            });
        }

    }
}
