using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.MovieCollection;
using P06Shop.Shared.Services.MovieService;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class MoviesViewModel : ObservableObject
    {
        private readonly IMovieService _movieService;
        private readonly MovieDetailsView _movieDetailsView;
        private readonly IMessageDialogService _messageDialogService;
        public ObservableCollection<Movie> Movies { get; set; }

        [ObservableProperty]
        private Movie selectedMovie;

        public MoviesViewModel(IMovieService movieService, MovieDetailsView movieDetailsView, IMessageDialogService messageDialogService)
        {
            _messageDialogService = messageDialogService;
            _movieDetailsView = movieDetailsView;
            _movieService = movieService;
            Movies = new ObservableCollection<Movie>();
            GetMovies();
        }

        public async Task GetMovies()
        {
            Movies.Clear();
            var moviesResult = await _movieService.GetMoviesAsync();
            if (moviesResult.Success)
            {
                foreach (var m in moviesResult.Data)
                {
                    Movies.Add(m);
                }
            }
        }

        public async Task CreateMovie()
        {
            var newMovie = new Movie()
            {
                Title = selectedMovie.Title,
                Genre = selectedMovie.Genre,
                LengthInMinutes = selectedMovie.LengthInMinutes,
                ReleaseDate = selectedMovie.ReleaseDate,
                CountryOfOrigin = selectedMovie.CountryOfOrigin,
                Director = selectedMovie.Director,
            };

            var result =  await _movieService.CreateMovieAsync(newMovie);
            if (result.Success)
                await GetMovies();
            else
                _messageDialogService.ShowMessage(result.Message);  
        }

        public async Task UpdateMovie()
        {
            var movieToUpdate = new Movie()
            {
                Id = selectedMovie.Id,
                Title = selectedMovie.Title,
                Genre = selectedMovie.Genre,
                LengthInMinutes = selectedMovie.LengthInMinutes,
                ReleaseDate = selectedMovie.ReleaseDate,
                CountryOfOrigin = selectedMovie.CountryOfOrigin,
                Director = selectedMovie.Director,
            };

            await _movieService.UpdateMovieAsync(movieToUpdate);
            GetMovies();
        }

        public async Task DeleteMovie()
        {
            await _movieService.DeleteMovieAsync(selectedMovie.Id);
            await GetMovies();
        }

        [RelayCommand]
        public async Task ShowDetails(Movie movie)
        {
            _movieDetailsView.Show();
            _movieDetailsView.DataContext = this;
            SelectedMovie = movie;
        }


        [RelayCommand]
        public async Task Save()
        {
            if (selectedMovie.Id == 0)
            {
                CreateMovie();
            }
            else
            {
                UpdateMovie();
            }

        }

        [RelayCommand]
        public async Task Delete()
        {
            DeleteMovie();
        }

        [RelayCommand]
        public async Task New()
        {
            _movieDetailsView.Show();
            _movieDetailsView.DataContext = this;
            SelectedMovie = new Movie(); 
        }


    }
}