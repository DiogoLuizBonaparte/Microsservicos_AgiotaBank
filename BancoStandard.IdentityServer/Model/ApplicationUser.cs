using Microsoft.AspNetCore.Identity;

namespace BancoStandard.IdentityServer.Model
{
    public class ApplicationUser : IdentityUser
    {
        private string Firstname { get; set; }
        private string LastName { get; set; }
    }
}
