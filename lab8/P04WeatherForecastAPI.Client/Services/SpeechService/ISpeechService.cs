using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.Services.SpeechService
{
    public interface ISpeechService
    {
        Task<string> RecognizeAsync();
    }
}
