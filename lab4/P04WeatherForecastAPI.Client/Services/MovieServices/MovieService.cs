using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using P04WeatherForecastAPI.Client.Configuration;
using P06Shop.Shared;
using P06Shop.Shared.MovieCollection;
using P06Shop.Shared.Services.MovieService;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
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
            var url = _appSettings.BaseMovieEndpoint.CreateMovieEndpoint;
            var response = await _httpClient.PostAsJsonAsync(url, movie);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Movie>>();
            return result;
        }

        public async Task<ServiceResponse<bool>> DeleteMovieAsync(int id)
        {
            string uri = _appSettings.BaseMovieEndpoint.Base_url;
            uri += string.Format(_appSettings.BaseMovieEndpoint.DeleteMovieEndpoint, id);
            uri = uri[4..] ;
            
            var response = await _httpClient.DeleteAsync(uri);
            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<bool>>(json);
        

            return result;
        }

        public async Task<ServiceResponse<Movie>> GetMovieByIdAsync(int id)
        {
            var url = _appSettings.BaseMovieEndpoint.GetMovieByIdEndpoint.Replace("{id}", id.ToString());
            
            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Movie>>();
            return result;
        }

        public async Task<ServiceResponse<List<Movie>>> GetMoviesAsync()
        {
            var url = _appSettings.BaseMovieEndpoint.GetAllMoviesEndpoint;
            
            var response = await _httpClient.GetAsync(url);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<List<Movie>>>();
            return result;
        }

    
        public async Task<ServiceResponse<Movie>> UpdateMovieAsync(Movie movie)
        {
            var url = _appSettings.BaseMovieEndpoint.UpdateMovieEndpoint.Replace("{id}", movie.Id.ToString());
            
            var response = await _httpClient.PutAsJsonAsync(url, movie);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Movie>>();
            return result;
        }
    }
}
