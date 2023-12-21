using P04WeatherForecastAPI.Client.ViewModels;

namespace P12MAUI.Client
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage(MoviesViewModel moviesViewModel)
        {
            InitializeComponent();
            BindingContext = moviesViewModel;
        }

       
    }
}