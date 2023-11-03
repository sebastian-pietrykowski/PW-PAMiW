using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using P04WeatherForecastAPI.Client.Configuration;
using P06Shop.Shared;
using P06Shop.Shared.MovieCollection;
using P06Shop.Shared.Services.MovieService;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.Services.MovieServices
{
    internal class MovieService : IMovieService
    {
        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;
        public MovieService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient= httpClient;
            _appSettings= appSettings.Value;
        }

        //// skopiowane z postmana 
        //public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        //{
        //    //var client = new HttpClient();   
        //    var request = new HttpRequestMessage(HttpMethod.Get, _appSettings.BaseProductEndpoint.GetAllProductsEndpoint);
        //    var response = await _httpClient.SendAsync(request);
        //    response.EnsureSuccessStatusCode();        
        //    var json = await response.Content.ReadAsStringAsync();
        //    var result = JsonConvert.DeserializeObject<ServiceResponse<List<Product>>>(json);
        //    return result;
        //}

        public async Task<ServiceResponse<Movie>> CreateMovieAsync(Movie movie)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<bool>> DeleteMovieAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<Movie>> GetMovieByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Movie>>> GetMoviesAsync()
        {
            var response = await _httpClient.GetAsync(_appSettings.BaseMovieEndpoint.GetAllMoviesEndpoint);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<List<Movie>>>(json);
            return result;
        }


    
        public async Task<ServiceResponse<Movie>> UpdateMovieAsync(Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
