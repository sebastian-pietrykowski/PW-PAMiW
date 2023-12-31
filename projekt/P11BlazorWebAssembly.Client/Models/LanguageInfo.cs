using  System.Globalization;

namespace P11BlazorWebAssembly.Client.Models
{
    public class LanguageInfo
    {
        public string Language { get; set; }
        public string FlagCssStyle { get; set; }
        public CultureInfo CultureInfo { get; set; }
    }
}

