using P04WeatherForecastAPI.Client.Models;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public class NeighborsViewModel
    {
        public City[] Neighbors { get; set; }
        
        public NeighborsViewModel(City[] neighbors)
        {
            Neighbors = neighbors;
        }
    }
}
