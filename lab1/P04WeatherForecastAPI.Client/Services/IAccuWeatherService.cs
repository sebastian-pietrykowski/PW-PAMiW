using P04WeatherForecastAPI.Client.Models;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.Services
{
    public interface IAccuWeatherService
    {
        Task<City[]> GetLocations(string locationName);
        Task<Weather?> GetCurrentConditions(string cityKey);
        Task<City[]> GetNeighbors(string cityKey);
        Task<GeoPosition?> GetGeoPosition(string locationName);
        Task<TimeZoneModel?> GetTimeZone(string locationName);
        Task<AdministrativeArea?> GetAdministrativeArea(string locationName);
        Task<ManyDaysForecast?> GetFiveDaysDailyForecast(string locationName);
        Task<HourlyForecast[]> GetSixHoursHourlyForecast(string locationName);
    }
}