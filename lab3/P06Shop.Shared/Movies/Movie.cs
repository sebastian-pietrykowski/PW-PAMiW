namespace P06Shop.Shared.Movies
{
    public class Movie
    {
        public required int Id { get; set; }

        public required string Title { get; set; }

        public required string Genre { get; set; }

        public required int LengthInMinutes { get; set; }

        public required DateTime ReleaseDate { get; set; }

        public required string CountryOfOrigin { get; set; }

        public required string Director { get; set; }

    }
}