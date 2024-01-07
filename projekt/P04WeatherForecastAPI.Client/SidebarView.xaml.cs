// using System;
// using System.Windows.Controls;
// using P04Library.Client;
// using System.Reflection;
// using System.Runtime.CompilerServices;

// using CommunityToolkit.Mvvm.Input;

// namespace P04WeatherForecastAPI.Client
// {
//     public partial class SidebarView : UserControl
//     {
//         public SidebarView()
//         {
//             InitializeComponent();
//             this.DataContext = this;
//         }

//         [RelayCommand]
//         public async void SwitchTheme()
//         {
//             System.Windows.MessageBox.Show(AppUserSettings.DarkMode.ToString());
//             AppUserSettings.SwitchTheme();
//         }
//     }
// }