using Bogus;
using P06Shop.Shared.MovieCollection;

namespace P07Shop.DataSeeder
{
    public class MovieSeeder
    {
        public static List<Movie> GenerateMovieData()
        {
            int productId = 1;
            var movieFaker = new Faker<Movie>("pl")
                .UseSeed(123456)
                .RuleFor(x => x.Id, x => productId++)
                .RuleFor(x => x.Description, x => x.Commerce.ProductDescription())
                .RuleFor(x => x.Title, x => x.Commerce.ProductName())
                .RuleFor(x => x.LengthInMinutes, x => x.Random.Int(20, 250))
                .RuleFor(x => x.ReleaseDate, x => x.Date.Past(30))
                .RuleFor(x => x.CountryOfOrigin, x => x.Address.Country())
                .RuleFor(x => x.Director, x => x.Person.FullName);

            return movieFaker.Generate(10).ToList();

        }
    }
}