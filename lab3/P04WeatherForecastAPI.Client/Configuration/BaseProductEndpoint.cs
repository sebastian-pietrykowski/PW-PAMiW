using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.Configuration
{
    internal class BaseProductEndpoint
    {
        public string Base_url { get; set; }
        public string GetAllProductsEndpoint {  get; set; }
    }
}
