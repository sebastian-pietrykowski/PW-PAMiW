using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.Configuration
{
    internal class AppSettings
    {
        public string DefaultLanguage { get; set; }

        public string BaseAPIUrl { get; set; }

        public BaseProductEndpoint BaseProductEndpoint { get; set; }


    }
}
