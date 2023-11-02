using P06Shop.Shared.Movies;

namespace P06Shop.Shared.Services.MovieService
{
    public interface IMovieService
    {
        Task<ServiceResponse<List<Movie>>> GetMoviesAsync();
    }
}