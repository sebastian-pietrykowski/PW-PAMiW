using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using P04WeatherForecastAPI.Client;

using CommunityToolkit.Mvvm.Input;

namespace P04Library.Client
{
    public class AppUserSettings
    {
        public static string Language = "en-US"; // "en-US", "pl-PL"
        public static bool DarkMode = false;

        public static void LoadSettings()
        {
            Language = "en-us";
        }


        public static void SwitchTheme()
        {
            DarkMode = !DarkMode;
            UpdateResources();
        }

        public static void UpdateResources()
        {
            Uri themeUri = new Uri("Styles/" + (DarkMode ? "Dark" : "Light") + "Theme.xaml", UriKind.Relative);

            App.Current.Resources.Clear();
            App.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = themeUri });
        }

        public static void SwitchLanguage()
        {
        }

        public static void SetLanguage(string language)
        {
            Language = language;
        }

    }
}