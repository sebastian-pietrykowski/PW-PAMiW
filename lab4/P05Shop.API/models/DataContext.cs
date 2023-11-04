using Microsoft.EntityFrameworkCore;
using P06Shop.Shared.MovieCollection;
using P06Shop.Shared.Shop;
using P07Shop.DataSeeder;

namespace P05Shop.API.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent api 
             modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Movie>()
                .Property(m => m.Genre)
                .HasMaxLength(50);

            modelBuilder.Entity<Movie>()
                .Property(m => m.LengthInMinutes)
                .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(m => m.ReleaseDate)
                .IsRequired();

            modelBuilder.Entity<Movie>()
                .Property(m => m.CountryOfOrigin)
                .HasMaxLength(50);

            modelBuilder.Entity<Movie>()
                .Property(m => m.Director)
                .HasMaxLength(100);

            modelBuilder.Entity<Movie>().HasData(MovieSeeder.GenerateMovieData());
        }
    }
}
// instalacja dotnet ef 
//dotnet tool install --global dotnet-ef

// aktualizacja 
//dotnet tool update --global dotnet-ef

// dotnet ef migrations add [nazwa_migracji]
// dotnet ef database update 


// cofniecie migraji niezaplikowanych 
//dotnet ef migrations remove