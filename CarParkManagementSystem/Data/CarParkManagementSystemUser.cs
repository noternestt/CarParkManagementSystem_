using Microsoft.AspNetCore.Identity;

namespace CarParkManagementSystem.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class CarParkManagementSystemUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
