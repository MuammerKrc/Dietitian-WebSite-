using System.Collections.Generic;

namespace app.webui.Models
{
    public class UserModel
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public IEnumerable<string> SelectedRoles { get; set; }
        public List<string> ReturnedRoles { get; set; }
        public UserModel()
        {
            ReturnedRoles = new List<string>();
        }
    }
}