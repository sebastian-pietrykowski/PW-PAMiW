using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using P06Shop.Shared.Auth;
using P06Shop.Shared.Services.AuthService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly IAuthService _authService;
        public static string Token { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        private readonly Window Window;


        public LoginViewModel(IAuthService authService)
        {
            UserLoginDTO = new UserLoginDTO();
            _authService = authService;
        }

        [ObservableProperty]
        private UserLoginDTO userLoginDTO;

    
        public bool DoShowMessage {
            get
            {
                return !string.IsNullOrEmpty(Message);
            }
        }

        public bool IsLoggedIn {
            get
            {
                return !string.IsNullOrEmpty(Token);
            }
        }
         
        public async Task Login(string password)
        {
            UserLoginDTO.Password = password;
            var response = await _authService.Login(UserLoginDTO);
            if (response.Success)
            {
                Token = response.Data;
                OnPropertyChanged(nameof(Token));
                OnPropertyChanged(nameof(IsLoggedIn));

                App.Current.Windows[2].Close();
            }
            else
            {
                Message = "Incorrect data";
                OnPropertyChanged(nameof(Message));
                OnPropertyChanged(nameof(DoShowMessage));
            }
            
        }

        public async Task Logout()
        {
            Token = null;
            OnPropertyChanged(nameof(Token));
            OnPropertyChanged(nameof(IsLoggedIn));
        }
    }
}
