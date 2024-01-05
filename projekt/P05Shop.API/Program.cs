using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using P05Shop.API.Models;
using P05Shop.API.Services.AuthService;
using P05Shop.API.Services.ProductService;
using P06Shop.Shared.Services.ProductService;
using P05Shop.API.Services.MovieService;
using P06Shop.Shared.Services.MovieService;
using System.Text;
using Microsoft.AspNetCore.Authentication.Google;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Microsoft.EntityFrameworkCore.SqlServer
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
    

builder.Services.AddScoped<IMovieService, P05Shop.API.Services.MovieService.MovieService>();
builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddHttpClient();
// addScoped - obiekt jest tworzony za kazdym razem dla nowego zapytania http
// jedno zaptranie tworzy jeden obiekt 

// addTransinet obiekt jest tworzony za kazdym razem kiedy odwolujmey sie do konstuktora 
// nawet wielokrotnie w cyklu jedengo zaptrania 

 //addsingleton - nowa instancja klasy tworzona jest tylko 1 na caly cykl trwania naszej aplikacji 

//autentykacja 

string token = builder.Configuration.GetSection("AppSettings:Token").Value;
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
    {
       // options.Authority = "https://localhost:5001";
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(token)),
            ValidateIssuerSigningKey = true,
        };
    })
    .AddGoogle(googleOptions =>
    {
        googleOptions.ClientId = builder.Configuration["Authentication:Google:ClientId"];
        googleOptions.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
    });

// builder.Services.AddAuthorization();

builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsePolicy", builder =>
    builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("MyCorsePolicy");

app.UseAuthorization();
app.UseAuthorization();

app.MapControllers();

app.Run();