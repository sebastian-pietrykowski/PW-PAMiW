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
using P04Library.Client;

namespace P04WeatherForecastAPI.Client.ViewModels
{
    public partial class SidebarViewModel : ObservableObject
    {
        // private readonly AppCurrentResources _appCurrentResources;

        public SidebarViewModel()
        {
            // _appCurrentResources = appCurrentResources;
        }

        // [ObservableProperty]
        // private UserLoginDTO userLoginDTO;

         
        // public async Task Login(string password)
        // {
        //     UserLoginDTO.Password = password;
        //     var response = await _authService.Login(UserLoginDTO);
        //     if (response.Success)
        //     {
        //         System.Windows.MessageBox.Show("Success");
        //         Token = response.Data;
        //     }
        //     else
        //     {
        //         System.Windows.MessageBox.Show("Failure");
        //     }
            
        // }

        // public async Task Logout()
        // {
        //     Token = null;
            
        // }

        // [RelayCommand]
        // public async Task MouseEnter()
        // {
             
        // }




    }

}
