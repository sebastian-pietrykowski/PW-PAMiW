using P06Shop.Shared;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.MovieCollection;
using P07Shop.DataSeeder;
using P05Shop.API.Exceptions;
using Bogus;
using P05Shop.API.Models;
using Microsoft.EntityFrameworkCore;

namespace P05Shop.API.Services.MovieService
{
    public class MovieService : IMovieService
    {
         private readonly DataContext _dataContext;

        public MovieService(DataContext context)
        {
            _dataContext = context;
        }

        public async Task<ServiceResponse<List<Movie>>> GetMoviesAsync()
        {
            var movies = await _dataContext.Movies.ToListAsync();

            try
            {
                var response = new ServiceResponse<List<Movie>>()
                {
                    Data = movies,
                    Message = "Ok",
                    Success = true
                };

                return response;
            }
            catch (Exception)
            {
                return new  ServiceResponse<List<Movie>>()
                {
                    Data = null,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
           
        }

        public async Task<ServiceResponse<Movie>> GetMovieByIdAsync(int id)
        {
            try
            {
                var movie = _dataContext.Find<Movie>(id);
                if (movie == null)
                {
                    return new ServiceResponse<Movie>()
                    {
                        Data = null,
                        Message = "Movie not found",
                        Success = false
                    };
                }
                else {
                    return new ServiceResponse<Movie>()
                    {
                        Data = movie,
                        Message = "Ok",
                        Success = true
                    };
                }
            }
            catch (Exception)
            {
                return new  ServiceResponse<Movie>()
                {
                    Data = null,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<Movie>> CreateMovieAsync(Movie movie)
        {
            try
            {
                CheckIfMovieAlreadyExists(movie.Id);
                _dataContext.Movies.Add(movie);
                await _dataContext.SaveChangesAsync();
                return new ServiceResponse<Movie>() { Data = movie, Success = true };
            }
            catch (MovieAlreadyExistsException)
            {
                return new ServiceResponse<Movie>()
                {
                    Data = null,
                    Message = "Movie already exists",
                    Success = false
                };
            }
            catch (Exception)
            {
                return new ServiceResponse<Movie>()
                {
                    Data = null,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<Movie>> UpdateMovieAsync(Movie movie)
        {
            try
            {
                CheckIfMovieDoesNotExist(movie.Id);
                 var movieToEdit = new Movie() { Id = movie.Id };
                _dataContext.Movies.Attach(movieToEdit);

                movieToEdit.Title = movie.Title;
                movieToEdit.Genre = movie.Genre;
                movieToEdit.LengthInMinutes = movie.LengthInMinutes;
                movieToEdit.ReleaseDate = movie.ReleaseDate;
                movieToEdit.CountryOfOrigin = movie.CountryOfOrigin;
                movieToEdit.Director = movie.Director;

                await _dataContext.SaveChangesAsync();
                return new ServiceResponse<Movie> { Data = movieToEdit, Success = true };
            }
            catch (MovieDoesNotExistException)
            {
                return new ServiceResponse<Movie>()
                {
                    Data = null,
                    Message = "Movie does not exists",
                    Success = false
                };
            }
            catch (Exception)
            {
                return new ServiceResponse<Movie>()
                {
                    Data = null,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
        }

        public async Task<ServiceResponse<bool>> DeleteMovieAsync(int id)
        {
            try
            {
                CheckIfMovieDoesNotExist(id);

                 var product = new Movie() { Id = id };
                _dataContext.Movies.Attach(product);
                _dataContext.Movies.Remove(product);
                await _dataContext.SaveChangesAsync();

                return new ServiceResponse<bool>()
                {
                    Data = true,
                    Success = true
                };
            }
            catch (MovieDoesNotExistException)
            {
                return new ServiceResponse<bool>()
                {
                    Data = false,
                    Message = "Movie does not exists",
                    Success = false
                };
            }
            catch (Exception)
            {
                return new ServiceResponse<bool>()
                {
                    Data = false,
                    Message = "Problem with dataseeder library",
                    Success = false
                };
            }
        }

        private void CheckIfMovieDoesNotExist(int id) {
            bool exists = _dataContext.Find<Movie>(id) != null;
            if (!exists) {
                throw new MovieDoesNotExistException();
            }
        }

        private void CheckIfMovieAlreadyExists(int id) {
            bool exists = _dataContext.Find<Movie>(id) != null;
            if (exists) {
                throw new MovieAlreadyExistsException();
            }
        }
    }
}
