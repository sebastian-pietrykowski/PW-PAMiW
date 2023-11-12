 
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using Newtonsoft.Json;
using P06Shop.Shared;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.MovieCollection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows;

namespace P06Shop.Shared.Services.MovieService
{
    public class MovieService : IMovieService
    {

        private readonly HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        private readonly string _baseUrl = "http://localhost:5093/api/Movie/";
        public MovieService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }

        public async Task<ServiceResponse<Movie>> CreateMovieAsync(Movie movie)
        {
            var response = await _httpClient.PostAsJsonAsync(_baseUrl, movie);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Movie>>();
            return result;
        }

        public async Task<ServiceResponse<bool>> DeleteMovieAsync(int id)
        {
            // jesli uzyjemy / na poczatku to wtedy sciezka trakktowana jest od root czyli pomija czesc środkową adresu 
            // zazwyczaj unikamy stosowania / na poczatku 
            var response = await _httpClient.DeleteAsync($"{_baseUrl}{id}");
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
            return result;
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


        // alternatywny sposób pobierania danych 
        public async Task<ServiceResponse<List<Movie>>> GetMoviesAsync()
        {
            var response = await _httpClient.GetAsync(_baseUrl);
            if (!response.IsSuccessStatusCode)
                return new ServiceResponse<List<Movie>>
                {
                    Success = false,
                    Message = "HTTP request failed"
                };

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<List<Movie>>>(json)
                ?? new ServiceResponse<List<Movie>> { Success = false, Message = "Deserialization failed" };

            result.Success = result.Success && result.Data != null;

            return result;
        }

        public async Task<ServiceResponse<Movie>> GetMovieByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}{id}");
            if (!response.IsSuccessStatusCode)
                return new ServiceResponse<Movie>
                {
                    Success = false,
                    Message = "HTTP request failed"
                };

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ServiceResponse<Movie>>(json)
                ?? new ServiceResponse<Movie> { Success = false, Message = "Deserialization failed" };

            result.Success = result.Success && result.Data != null;

            return result;
        }


        // wersja 1 
        //public async Task<ServiceResponse<Product>> UpdateProductAsync(Product product)
        //{
        //    var response = await _httpClient.PutAsJsonAsync(_appSettings.BaseProductEndpoint.GetAllProductsEndpoint, product);
        //    var json = await response.Content.ReadAsStringAsync();
        //    var result = JsonConvert.DeserializeObject<ServiceResponse<Product>>(json);
        //    return result;
        //}

        // wersja 2 
        public async Task<ServiceResponse<Movie>> UpdateMovieAsync(Movie movie)
        {
            var response = await _httpClient.PutAsJsonAsync(_baseUrl, movie);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Movie>>();
            return result;
        }
    }
}
