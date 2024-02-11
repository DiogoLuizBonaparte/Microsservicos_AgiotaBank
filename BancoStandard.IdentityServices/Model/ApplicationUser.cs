using Microsoft.AspNetCore.Identity;

namespace BancoStandard.IdentityServices.Model
{
    public class ApplicationUser : IdentityUser
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
    }
}
