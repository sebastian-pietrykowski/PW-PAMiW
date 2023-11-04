using P06Shop.Shared;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.MovieCollection;
using P07Shop.DataSeeder;
using P05Shop.API.Exceptions;
using Bogus;

namespace P05Shop.API.Services.MovieService
{
    public class MovieService : IMovieService
    {
        private List<Movie> _movieRepository { get; set; }

        public MovieService()
        {
            _movieRepository = new List<Movie>();
            InitializeData();
        }

        public async Task<ServiceResponse<List<Movie>>> GetMoviesAsync()
        {
            try
            {
                var response = new ServiceResponse<List<Movie>>()
                {
                    Data = _movieRepository,
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
                var movie = _movieRepository.Where(x => x.Id == id).First();
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
                _movieRepository.Add(movie);

                var response = new ServiceResponse<Movie>()
                {
                    Data = movie,
                    Message = "Ok",
                    Success = true
                };

                return response;
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
                await CheckIfMovieDoesNotExist(movie.Id);
                _movieRepository = _movieRepository.Where(x => x.Id != movie.Id).ToList();
                _movieRepository.Add(movie);

                var response = new ServiceResponse<Movie>()
                {
                    Data = movie,
                    Message = "Ok",
                    Success = true
                };

                return response;
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
                await CheckIfMovieDoesNotExist(id);
                _movieRepository = _movieRepository.Where(x => x.Id != id).ToList();

                var response = new ServiceResponse<bool>()
                {
                    Data = true,
                    Message = "Ok",
                    Success = true
                };

                return response;
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

        private void InitializeData() {
            _movieRepository = MovieSeeder.GenerateMovieData();
        }

        private async Task CheckIfMovieDoesNotExist(int id) {
            bool exists = await Task.FromResult(_movieRepository.Select(data => data.Id).Contains(id));
            if (!exists) {
                throw new MovieDoesNotExistException();
            }
        }

        private void CheckIfMovieAlreadyExists(int id) {
            bool exists = _movieRepository.Select(data => data.Id).Contains(id);
            if (exists) {
                throw new MovieAlreadyExistsException();
            }
        }
    }
}
