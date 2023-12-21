namespace P06Shop.Shared.MovieCollection
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerSurname { get; set; }
        public int Rating { get; set; }
        public string Note { get; set; }
    }

}