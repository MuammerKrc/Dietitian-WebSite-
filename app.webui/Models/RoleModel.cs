using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using app.webui.Identity;
using Microsoft.AspNetCore.Identity;

namespace app.webui.Models
{
    public class RoleModel
    {
      
        [Required]
        public string Name { get; set; }
    }
    public class RoleDetail
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<User> NonMembers { get; set; }
        public IEnumerable<User> Members { get; set; }
    }

    public class RoleEditModel
    {
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }

    }
}