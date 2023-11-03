using CommunityToolkit.Mvvm.ComponentModel;
using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services.WeatherServices;
using P06Shop.Shared.MovieCollection;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.Services.ProductService;
using P06Shop.Shared.Shop;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class MoviesViewModel : ObservableObject
    {
        private readonly IMovieService _movieService;

        public ObservableCollection<Movie> Movies { get; set; }

        public MoviesViewModel(IMovieService movieService)
        {
            _movieService = movieService;
            Movies = new ObservableCollection<Movie>();          
        }

        public async void GetMovies()
        {
            var moviesResult = await _movieService.GetMoviesAsync();
            if (moviesResult.Success)
            {
                foreach (var m in moviesResult.Data)
                {
                    Movies.Add(m);
                }
            }
        }

    }
}
