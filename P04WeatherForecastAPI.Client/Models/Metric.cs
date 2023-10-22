using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.Models
{
    internal class Metric
    {
        public required double Value { get; set; }
        public required string Unit { get; set; }
        public required int UnitType { get; set; }
    }
}
