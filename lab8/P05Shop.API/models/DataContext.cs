using Microsoft.EntityFrameworkCore;
using P06Shop.Shared.MovieCollection;
using P07Shop.DataSeeder;

namespace P05Shop.API.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres{ get; set; }
        public DbSet<Actor> Actors{ get; set; }
        public DbSet<MovieActors> MovieActors{ get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent api 
             modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(100);

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
            
            modelBuilder.Entity<MovieActors>()
                .HasKey(ma => new { ma.MovieId, ma.ActorId }); // Ustawienie klucza głównego tabeli pośredniczej

            modelBuilder.Entity<MovieActors>()
                .HasOne(ma => ma.Movie)
                .WithMany(m => m.MovieActors)
                .HasForeignKey(ma => ma.MovieId); // Klucz obcy dla Movie w tabeli pośredniczej

            modelBuilder.Entity<MovieActors>()
                .HasOne(ma => ma.Actor)
                .WithMany(a => a.MovieActors)
                .HasForeignKey(ma => ma.ActorId); // Klucz obcy dla Actor w tabeli pośredniczej
            
            modelBuilder.Entity<Movie>()
            .HasOne(m => m.Review)
            .WithOne(r => r.Movie)
            .HasForeignKey<Review>(m => m.MovieId);

            modelBuilder.Entity<Genre>()
                .HasMany(g => g.Movies)
                .WithOne(m => m.Genre);

            modelBuilder.Entity<Review>()
                .HasKey(r =>  r.MovieId);

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