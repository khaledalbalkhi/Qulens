using Microsoft.AspNetCore.Authentication.Cookies;

namespace Qulens.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string Name { get; set; } = string.Empty;
        //public string Email { get; set; } = string.Empty;
        //public string Password { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public string? ImageUrl { get; set; } = string.Empty;
        // navigation property
        public int PostId { get; set; }
        public virtual List<Post>? Posts { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}