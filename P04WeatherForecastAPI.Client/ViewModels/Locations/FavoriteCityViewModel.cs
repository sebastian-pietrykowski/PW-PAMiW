using CommunityToolkit.Mvvm.ComponentModel;
using P04WeatherForecastAPI.Client.Models;
using P04WeatherForecastAPI.Client.Services;
using System.Collections.ObjectModel;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class FavoriteCityViewModel : ObservableObject
    {
        private readonly IFavoriteCityService _favoriteCityService;

        private ObservableCollection<FavoriteCity>? _favoriteCity;

        [ObservableProperty]
        private FavoriteCity? selectedCity;


        public FavoriteCityViewModel(IFavoriteCityService favoriteCityService)
        {
            _favoriteCityService = favoriteCityService;
        }


    }
}
