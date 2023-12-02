namespace P06Shop.Shared.MovieCollection
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string CountryOfOrigin { get; set; }

        public double Height { get; set; }

        public ICollection<MovieActors> MovieActors { get; set; }
    }

}