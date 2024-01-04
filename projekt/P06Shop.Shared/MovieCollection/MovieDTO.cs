// using System.ComponentModel;
// using System.ComponentModel.DataAnnotations;

// namespace P06Shop.Shared.MovieCollection
// {
//     public class MovieDto
//     {
//         [Required]
//         public int Id { get; set; }

//         [Required(ErrorMessage="Title is required.")]
//         [MinLength(2, ErrorMessage = "Title must be at least 2 characters long.")]
//         public string Title { get; set; } = string.Empty;

//         [Required(ErrorMessage="Length is required.")]
//         [Range(20, 250, ErrorMessage = "Length must be between 20 and 250.")]
//         public int LengthInMinutes { get; set; } = 0;

//         [Required(ErrorMessage = "Release date is required.")]  
//         [DataType(DataType.Date)] 
//         public DateTime ReleaseDate { get; set; } = DateTime.Now;

//         [Required(ErrorMessage="Country of origin is required.")]
//         [MinLength(5, ErrorMessage = "Country of origin must be at least 5 characters long.")]
//         public string CountryOfOrigin { get; set; } = string.Empty;

//         [Required(ErrorMessage="Director's full name is required.")]
//         [MinLength(5, ErrorMessage = "Director's full name must be at least 5 characters long.")]
//         public string Director { get; set; } = string.Empty;

//         [Required(ErrorMessage="Description is required.")]
//         [MinLength(5, ErrorMessage = "Description must be at least 20 characters long.")]
//         public string Description { get; set; } = string.Empty;
//     }
// }