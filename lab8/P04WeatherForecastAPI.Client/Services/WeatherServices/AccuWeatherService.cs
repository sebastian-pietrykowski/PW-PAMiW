using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using P04WeatherForecastAPI.Client.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using P04WeatherForecastAPI.Client.Services.WeatherServices;

namespace P04WeatherForecastAPI.Client.Services
{
    internal class AccuWeatherService : IAccuWeatherService
    {
        private const string base_url = "http://dataservice.accuweather.com";
        private const string autocomplete_endpoint = "locations/v1/cities/autocomplete?apikey={0}&q={1}&language={2}";
        private const string current_conditions_endpoint = "currentconditions/v1/{0}?apikey={1}&language={2}";
        private const string neighbors_endpoint = "locations/v1/cities/neighbors/{0}?apikey={1}&language={2}";
        private const string city_endpoint = "locations/v1/cities/search?apikey={0}&q={1}&language={2}";
        private const string five_days_daily_forecast_endpoint = "forecasts/v1/daily/5day/{0}?apikey={1}&language={2}&metric=true";
        private const string twelve_hours_hourly_forecast_endpoint = "forecasts/v1/hourly/12hour/{0}?apikey={1}&language={2}&metric=true";
        
        readonly string api_key;
        readonly string language;

        public AccuWeatherService()
        {
            var builder = new ConfigurationBuilder()
                .AddUserSecrets<App>()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetings.json"); 

            var configuration = builder.Build();
            api_key = configuration["api_key"] ?? "";
            language = configuration["default_language"] ?? "en";
        }


        public async Task<City[]> GetLocations(string locationName)
        {
            string uri = base_url + "/" + string.Format(autocomplete_endpoint, api_key, locationName, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                City[] cities = JsonConvert.DeserializeObject<City[]>(json) ?? Array.Empty<City>();

                return cities;
            }
        }

        public async Task<Weather?> GetCurrentConditions(string cityKey)
        {
            string uri = base_url + "/" + string.Format(current_conditions_endpoint, cityKey, api_key,language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                Weather[] weathers = JsonConvert.DeserializeObject<Weather[]>(json) ?? Array.Empty<Weather>();

                return weathers.FirstOrDefault();
            }
        }

        public async Task<City[]> GetNeighbors(string cityKey)
        {
            string uri = base_url + "/" + string.Format(neighbors_endpoint, cityKey, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                City[] neighbors = JsonConvert.DeserializeObject<City[]>(json) ?? Array.Empty<City>();

                return neighbors.Take(5).ToArray();
            }
        }

        public async Task<GeoPosition?> GetGeoPosition(string locationName) {
            string uri = base_url + "/" + string.Format(city_endpoint, api_key, locationName, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                City[] cities = JsonConvert.DeserializeObject<City[]>(json) ?? Array.Empty<City>();
                City? city = cities.FirstOrDefault();

                return city?.GeoPosition;
            }
        }

        public async Task<TimeZoneModel?> GetTimeZone(string locationName) {
            string uri = base_url + "/" + string.Format(city_endpoint, api_key, locationName, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                City[] cities = JsonConvert.DeserializeObject<City[]>(json) ?? Array.Empty<City>();
                City? city = cities.FirstOrDefault();

                return city?.TimeZone;
            }
        }

        public async Task<AdministrativeArea?> GetAdministrativeArea(string locationName) {
            string uri = base_url + "/" + string.Format(city_endpoint, api_key, locationName, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                City[] cities = JsonConvert.DeserializeObject<City[]>(json) ?? Array.Empty<City>();
                City? city = cities.FirstOrDefault();

                return city?.AdministrativeArea;
            }
        }

        public async Task<ManyDaysForecast?> GetFiveDaysDailyForecast(string locationName) {
            string uri = base_url + "/" + string.Format(five_days_daily_forecast_endpoint, locationName, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                ManyDaysForecast? manyDaysForecast = JsonConvert.DeserializeObject<ManyDaysForecast>(json);

                return manyDaysForecast;
            }
        }

        public async Task<HourlyForecast[]> GetSixHoursHourlyForecast(string locationName) {
            string uri = base_url + "/" + string.Format(twelve_hours_hourly_forecast_endpoint, locationName, api_key, language);
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(uri);
                string json = await response.Content.ReadAsStringAsync();
                HourlyForecast[] hourlyForecasts = JsonConvert.DeserializeObject<HourlyForecast[]>(json) ?? Array.Empty<HourlyForecast>();

                return hourlyForecasts.ToArray().Take(6).ToArray();
            }
        }
    }
}