using System.Windows;

namespace P04WeatherForecastAPI.Client
{
    /// <summary>
    /// Interaction logic for ProductDetailsView.xaml
    /// </summary>
    public partial class MovieDetailsView : Window
    {
        public MovieDetailsView()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}