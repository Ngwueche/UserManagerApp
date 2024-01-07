using Microsoft.AspNetCore.Identity;

namespace UserManagerApp.Models.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Twitter { get; set; } = string.Empty;
        public string GitHub { get; set; } = string.Empty;
    }
}
