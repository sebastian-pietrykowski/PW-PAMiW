namespace P06Shop.Shared.MovieCollection
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public int LengthInMinutes { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string CountryOfOrigin { get; set; }

        public string Director { get; set; }

    }
}