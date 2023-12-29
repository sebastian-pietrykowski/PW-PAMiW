using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Auth
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage="Email is required."),
        EmailAddress(ErrorMessage="Invalid email format.")]
        public string Email { get; set; } = string.Empty;
        
        [Required(ErrorMessage="Password is required."),
        MinLength(6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; } = string.Empty;
    }
}
