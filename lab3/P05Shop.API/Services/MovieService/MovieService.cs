using P06Shop.Shared;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.Movies;
using P07Shop.DataSeeder;

namespace P05Shop.API.Services.MovieService
{
    public class MovieService : IMovieService
    {
        public async Task<ServiceResponse<List<Movie>>> GetMoviesAsync()
        {
            try
            {
                var response = new ServiceResponse<List<Movie>>()
                {
                    Data = await Task.Run(MovieSeeder.GenerateMovieData),
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
    }
}
