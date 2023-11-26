using System.ComponentModel;

namespace P06Shop.Shared.MovieCollection
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int LengthInMinutes { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string CountryOfOrigin { get; set; }

        public string Director { get; set; }

        private string _description;


        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Genre? Genre { get; set; }
        public int? GenreId { get; set; }

        public Review? Review { get; set; }
        public int? ReviewId { get; set; }

        public ICollection<MovieActors> MovieActors { get; set; } = new List<MovieActors>();
    }
}