 
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

        public MovieService(HttpClient httpClient, IOptions<AppSettings> appSettings)
        {
            _httpClient = httpClient;
            _appSettings = appSettings.Value;
        }

        public async Task<ServiceResponse<Movie>> CreateMovieAsync(Movie movie)
        {
            var response = await _httpClient.PostAsJsonAsync(_appSettings.BaseMovieEndpoint.GetAllMoviesEndpoint, movie);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Movie>>();
            return result;
        }

        public async Task<ServiceResponse<bool>> DeleteMovieAsync(int id)
        {
            // jesli uzyjemy / na poczatku to wtedy sciezka trakktowana jest od root czyli pomija czesc środkową adresu 
            // zazwyczaj unikamy stosowania / na poczatku 
            var response = await _httpClient.DeleteAsync($"{id}");
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<bool>>();
            return result;
        }

        public async Task<ServiceResponse<List<Movie>>> GetMoviesAsync()
        {
            string url = _appSettings.BaseMovieEndpoint.GetAllMoviesEndpoint;
            // string url = "http://localhost:5093/api/Movie";
            var response = await _httpClient.GetAsync(url);
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
            var response = await _httpClient.GetAsync(id.ToString());
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

        public async Task<ServiceResponse<Movie>> UpdateMovieAsync(Movie movie)
        {
            var response = await _httpClient.PutAsJsonAsync(_appSettings.BaseMovieEndpoint.GetAllMoviesEndpoint, movie);
            var result = await response.Content.ReadFromJsonAsync<ServiceResponse<Movie>>();
            return result;
        }

        public async Task<ServiceResponse<List<Movie>>> SearchMoviesAsync(string text, int page, int pageSize)
        {

            try
            {
                string searchUrl = string.IsNullOrWhiteSpace(text) ? "" : $"/{text}";
                var response = await _httpClient.GetAsync(_appSettings.BaseMovieEndpoint.SearchMoviesEndpoint + searchUrl + $"/{page}/{pageSize}");
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
            catch (JsonException)
            {
                return new ServiceResponse<List<Movie>>
                {
                    Success = false,
                    Message = "Cannot deserialize data"
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return new ServiceResponse<List<Movie>>
                {
                    Success = false,
                    Message = "Network error"
                };
            }
        }
    }
}
