using Microsoft.AspNetCore.Identity;

namespace Gremmer.Shared.Users
{
    public class User : IdentityUser
    {
        public string Username { get; set; }
        public string EncryptedPassword { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
