using Microsoft.AspNetCore.Mvc;
using P04WeatherForecastAPI.Client.Models;

namespace P05Shop.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase //https://localhost:7230/api/WeatherForecast
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> GetMyOwnName()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //https://localhost:7230/api/WeatherForecast/onlytwo
        [HttpGet("onlyTwo")]
        public IEnumerable<WeatherForecast> GetOnlyTwoWeatherForecast()
        {
            return new WeatherForecast[2]
            {
                new WeatherForecast(){ Summary="one"},
                new WeatherForecast(){ Summary="two"},
            };
        }

        //https://localhost:7230/api/WeatherForecast/search?number=3
        [HttpGet("search")]
        public IEnumerable<WeatherForecast> GetWeatherForecasts([FromQuery] int number)
        {
            return Enumerable.Range(1, number).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
           .ToArray();
        }

        //https://localhost:7230/api/WeatherForecast/test/hello?number=4
        [HttpGet("test/{routeParam}")]
        public string GetValueFromPath([FromQuery]int number, [FromRoute]string routeParam )
        {
            return $"this is result: number : {number}, routeParam : {routeParam}";
               
        }

        //https://localhost:7230/api/WeatherForecast/filter?cityName=warsaw&country=poland
        [HttpGet("filter")]
        public string GetValueFromPath([FromQuery] string cityName, [FromQuery] string country)
        {
            return $"this is result: cityName : {cityName}, country : {country}";
        }

        //https://localhost:7230/api/WeatherForecast/filterComplicated?Version=1&Key=a&Type=a&Rank=100&LocalizedName=warszawa&Country.ID=1&Country.LocalizedName=Polska&AdministrativeArea.ID=1&AdministrativeArea.LocalizedName=a
        [HttpGet("filterComplicated")]
        public string GetValueFromPath2([FromQuery] City city)
        {
            return $"this is result: cityName : {city.LocalizedName}, country : {city.Country.LocalizedName}";
        }



        //https://localhost:7230/api/WeatherForecast
        [HttpPost]
        public string AddNewCity([FromBody] City city)
        {
            return 
                $"city: LocalizedName: {city.LocalizedName}, Rank : {city.Rank}";
        }

        //GET  - pobieranie danych 
        //POST - tworzenia
        //PUT - edycja
        //DELETE - usuwanie 

        //[HttpPost("newCity")]  //https://localhost:7230/api/WeatherForecast/newCity
        //[HttpPost("addCity")] //https://localhost:7230/api/WeatherForecast/addCity
        //public string MultiplePathsToOneMethod([FromBody] City city)
        //{
        //    return "city added";
        //}

        [HttpPost("newCity")]  //https://localhost:7230/api/WeatherForecast/newCity
        [HttpPost("addCity")] //https://localhost:7230/api/WeatherForecast/addCity
        public IActionResult MultiplePathsToOneMethod([FromBody] City city)
        {
            // return Ok("city added");
            //return StatusCode(200, "city added");

            if(city.LocalizedName == null) 
                return BadRequest("city added");

            try
            {
              //  int a = 0;
              //  int b = 4 / a;
                // proba dodawnia 
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }


            int id = 5;
            return Created($"https://localhost:7230/api/WeatherForecast/GetCity/{id}", city);
        }

        //https://localhost:7230/api/WeatherForecast/GetCity/5
        [HttpGet("GetCity/{id}")]
        public IActionResult GetCity([FromRoute] int id)
        {
            return Ok(new City() {  LocalizedName="warszawa"});
        }


        //https://localhost:7230/api/WeatherForecast/MyDynamicMethodName
        [HttpGet("[action]")]
        public IActionResult MyDynamicMethodName()
        {
            return Ok("Method invoked");
        } 

    }
}