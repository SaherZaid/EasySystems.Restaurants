using Microsoft.AspNetCore.Identity;

namespace EasySystems.Restaurants.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        // Optional ??? ???? ??????
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Helper (??????? ?????)
        public string FullName => $"{FirstName} {LastName}".Trim();
    }
}