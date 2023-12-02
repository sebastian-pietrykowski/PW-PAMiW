using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06Shop.Shared.Auth
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string Email { get; set; }

        public string Role { get; set; } = "Customer";

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
