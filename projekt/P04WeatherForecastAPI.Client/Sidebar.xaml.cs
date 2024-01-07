using System;
using System.Windows.Controls;

namespace P04WeatherForecastAPI.Client
{
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}