using Microsoft.AspNetCore.Mvc;
using P06Shop.Shared;
using P06Shop.Shared.MovieCollection;
using P06Shop.Shared.Services.MovieService;
using P06Shop.Shared.Shop;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Movie>>>> GetMovies()
        {
            var result = await _movieService.GetMoviesAsync();

            if (result.Success)
                return Ok(result);
            else
                return  StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Movie>>> GetMovieById([FromRoute] int id)
        {
            var result = await _movieService.GetMovieByIdAsync(id);

            if (result.Success)
                return Ok(result);
            else
                return  StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Movie>>> CreateMovie([FromBody] Movie movie)
        {
            try {
                ValidateInputMovie(movie);
            } catch (ArgumentNullException ex) {
                return BadRequest(ex.Message);
            }

            var result = await _movieService.CreateMovieAsync(movie);

            if (result.Success)
                return Ok(result);
            else
                return  StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<Movie>>> UpdateMovie([FromBody] Movie movie)
        {
            try {
                ValidateInputMovie(movie);
            } catch (ArgumentNullException ex) {
                return BadRequest(ex.Message);
            }
            
            var result = await _movieService.UpdateMovieAsync(movie);

            if (result.Success)
                return Ok(result);
            else
                return  StatusCode(500, $"Internal server error {result.Message}");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<bool>>> DeleteMovie([FromRoute] int id)
        {
            var result = await _movieService.DeleteMovieAsync(id);

            if (result.Success)
                return Ok(result);
            else
                return  StatusCode(500, $"Internal server error {result.Message}");
        }

        private void ValidateInputMovie(Movie movie) {
            if (movie == null)
                throw new ArgumentNullException(nameof(movie));

            if (string.IsNullOrEmpty(movie.Title))
                throw new ArgumentNullException(nameof(movie.Title));

            if (string.IsNullOrEmpty(movie.Genre))
                throw new ArgumentNullException(nameof(movie.Genre));

            if (movie.LengthInMinutes <= 0)
                throw new ArgumentNullException(nameof(movie.LengthInMinutes));

            if (movie.ReleaseDate == null)
                throw new ArgumentNullException(nameof(movie.ReleaseDate));

            if (string.IsNullOrEmpty(movie.CountryOfOrigin))
                throw new ArgumentNullException(nameof(movie.CountryOfOrigin));

            if (string.IsNullOrEmpty(movie.Director))
                throw new ArgumentNullException(nameof(movie.Director));
        }
    }
}
