using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using P06Shop.Shared.Configuration;
using P06Shop.Shared.Services.AuthService;
using P06Shop.Shared.Services.MovieService;
using P11BlazorWebAssembly.Client;
using P11BlazorWebAssembly.Client.Services.CustomAuthStateProvider;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var appSettings = builder.Configuration.GetSection(nameof(AppSettings));
var appSettingsSection = appSettings.Get<AppSettings>();

var uriBuilderAuth = new UriBuilder(appSettingsSection.BaseAPIUrl)
{};
builder.Services.AddHttpClient<IAuthService, AuthService>(client => client.BaseAddress = uriBuilderAuth.Uri);


var uriBuilderMovie = new UriBuilder(appSettingsSection.BaseAPIUrl)
{
   Path = appSettingsSection.BaseMovieEndpoint.Base_url,
};
builder.Services.AddHttpClient<IMovieService, MovieService>(client => client.BaseAddress = uriBuilderMovie.Uri);

//Microsoft.Extensions.Http

//builder.Services.Configure<AppSettings>(appSettings);
builder.Services.AddSingleton<IOptions<AppSettings>>(new OptionsWrapper<AppSettings>(appSettingsSection));

builder.Services.AddSingleton(appSettingsSection);
builder.Services.AddBlazoredLocalStorage();

// autorization
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddSingleton<ThemeService, ThemeService>();
//builder.Services.AddScoped<IAuthService, AuthService>();

var app = builder.Build();
await app.RunAsync();