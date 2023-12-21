using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using P06Shop.Shared.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04WeatherForecastAPI.Client.Services.SpeechService
{
    public class SpeechService : ISpeechService
    {
        private readonly SpeechSettings _speechSettings;

        public SpeechService(SpeechSettings speechSettings)
        {
            _speechSettings = speechSettings;
        }
        // Microsoft.CognitiveServices.Speech
        public async Task<string> RecognizeAsync()
        {
            var conf = SpeechConfig.FromSubscription(_speechSettings.SpeechApiKey, _speechSettings.SpeechRegion);
            return await RecognizeFromMic(conf);
        }

        private async Task<string> RecognizeFromMic(SpeechConfig speechConfig)
        {
            using var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            using var recognizer = new SpeechRecognizer(speechConfig, "pl-PL", audioConfig);

            var result = await recognizer.RecognizeOnceAsync();
            return result.Text;
        }
    }
}
