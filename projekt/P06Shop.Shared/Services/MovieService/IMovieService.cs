using P06Shop.Shared.MovieCollection;

namespace P06Shop.Shared.Services.MovieService
{
    public interface IMovieService
    {
        Task<ServiceResponse<List<MovieDto>>> GetMoviesAsync();

        Task<ServiceResponse<MovieDto>> GetMovieByIdAsync(int id);

        Task<ServiceResponse<MovieDto>> CreateMovieAsync(MovieDto movie);

        Task<ServiceResponse<MovieDto>> UpdateMovieAsync(MovieDto movie);

        Task<ServiceResponse<bool>> DeleteMovieAsync(int id);
        Task<ServiceResponse<List<MovieDto>>> SearchMoviesAsync(string text, int page, int pageSize);
    }
}