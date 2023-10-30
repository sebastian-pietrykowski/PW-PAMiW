using System.Collections.Generic;
using P04WeatherForecastAPI.Client.Models;

namespace P04WeatherForecastAPI.Client.Services
{
    public interface IFavoriteCityService
    {
        public List<FavoriteCity> GetAllFavoriteCities();

        public void AddFavoriteCity(FavoriteCity city);
        public void RemoveFavoriteCity(int id);
    }
}
