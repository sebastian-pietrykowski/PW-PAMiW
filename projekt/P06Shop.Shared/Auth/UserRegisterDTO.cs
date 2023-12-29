using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Auth
{

    public class UserRegisterDTO
    {
        [Required(ErrorMessage="Email is required."),
        EmailAddress(ErrorMessage="Invalid email format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage="Password is required."),
        MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; } = string.Empty;

        [Compare("Password", ErrorMessage ="The passwords do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage="Username is required."),
        MinLength(3, ErrorMessage = "Username must be at least 3 characters long.")]
        public string Username { get; set; } = string.Empty;
    }
}
