using Microsoft.AspNetCore.Identity;

namespace CentralWebApi.Models
{
    public class User : IdentityUser
    {
        public string UserName { get; set; }
        public string Password{ get; set; }
    }
}
