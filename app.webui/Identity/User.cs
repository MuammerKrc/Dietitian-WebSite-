using Microsoft.AspNetCore.Identity;

namespace app.webui.Identity
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
    }
}