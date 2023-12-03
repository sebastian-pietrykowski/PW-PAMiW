using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using P04WeatherForecastAPI.Client.MessageBox;
using P04WeatherForecastAPI.Client.ViewModels;
using P04WeatherForecastAPI.Client.Services.WeatherServices;
using P04WeatherForecastAPI.Client.Services.SpeechService;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.MessageBox;
using P06Shop.Shared.Services.AuthService;
using P06Shop.Shared.Services.MovieService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.Options;

namespace P04WeatherForecastAPI.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IServiceProvider _serviceProvider;
        IConfiguration _configuration;
        public App()
        {
            //wczytanie appsettings.json do konfiguracji 
            var builder = new ConfigurationBuilder()
              .AddUserSecrets<App>()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json");
            _configuration = builder.Build();



            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            _serviceProvider = serviceCollection.BuildServiceProvider();

        }

        private void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = ConfigureAppSettings(services);
            ConfigureAppServices(services, appSettingsSection);
            ConfigureViewModels(services);
            ConfigureViews(services);
            ConfigureHttpClients(services, appSettingsSection);
        }

        private AppSettings ConfigureAppSettings(IServiceCollection services)
        {
            var appSettings = _configuration.GetSection(nameof(AppSettings));
            var appSettingsSection = appSettings.Get<AppSettings>();
            // services.Configure<AppSettings>(appSettings);
            services.AddSingleton(appSettingsSection);

            return appSettingsSection;
        }

        private void ConfigureAppServices(IServiceCollection services, AppSettings appSettings)
        {
            // konfiguracja serwisów 
            services.AddSingleton<IAccuWeatherService, AccuWeatherService>();
            services.AddSingleton<IFavoriteCityService, FavoriteCityService>();
            services.AddSingleton<IMovieService, MovieService>();
            services.AddSingleton<IMessageDialogService, WpfMesageDialogService>();
            services.AddSingleton<ISpeechService>(_ => new SpeechService(appSettings.SpeechSettings));
        }

        private void ConfigureViewModels(IServiceCollection services)
        {

            // konfiguracja viewModeli 
            services.AddSingleton<MainViewModelV4>();
            services.AddSingleton<FavoriteCityViewModel>();
            services.AddSingleton<MoviesViewModel>();
            services.AddSingleton<LoginViewModel>();
            services.AddTransient<LoginView>();

            // services.AddSingleton<BaseViewModel,MainViewModelV3>();
        }

        private void ConfigureViews(IServiceCollection services)
        {
            // konfiguracja okienek 
            services.AddTransient<MainWindow>();
            services.AddTransient<FavoriteCitiesView>();
            services.AddTransient<LibraryMoviesView>();
            services.AddTransient<MovieDetailsView>();
        }

        private void ConfigureHttpClients(IServiceCollection services, AppSettings appSettingsSection)
        {
            var uriBuilderAuth = new UriBuilder(appSettingsSection.BaseAPIUrl) {};
            services.AddHttpClient<IAuthService, AuthService>(client => client.BaseAddress = uriBuilderAuth.Uri);

            var uriMovieBuilder = new UriBuilder(appSettingsSection.BaseAPIUrl)
            {
                Path = appSettingsSection.BaseMovieEndpoint.Base_url,
            };
            services.AddHttpClient<IMovieService, MovieService>(client => client.BaseAddress = uriMovieBuilder.Uri);

            services.AddSingleton<IOptions<AppSettings>>(new OptionsWrapper<AppSettings>(appSettingsSection));

        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = _serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }
}
