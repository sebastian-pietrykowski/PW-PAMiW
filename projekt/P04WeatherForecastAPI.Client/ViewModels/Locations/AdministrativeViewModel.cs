using P04WeatherForecastAPI.Client.Models;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class AdministrativeAreaViewModel
    {
        public string? LocalizedName { get; set; }

        public AdministrativeAreaViewModel(AdministrativeArea? administrativeArea)
        {
            LocalizedName = administrativeArea?.LocalizedName;
        }
    }
}