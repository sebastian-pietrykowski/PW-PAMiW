using P06Shop.Shared.MovieCollection;

namespace P06Shop.Shared.Services.MovieService
{
    public interface IMovieService
    {
        Task<ServiceResponse<List<Movie>>> GetMoviesAsync();

        Task<ServiceResponse<Movie>> GetMovieByIdAsync(int id);

        Task<ServiceResponse<Movie>> CreateMovieAsync(Movie movie);

        Task<ServiceResponse<Movie>> UpdateMovieAsync(Movie movie);

        Task<ServiceResponse<bool>> DeleteMovieAsync(int id);
        Task<ServiceResponse<List<Movie>>> SearchMoviesAsync(string text, int page, int pageSize);
    }
}