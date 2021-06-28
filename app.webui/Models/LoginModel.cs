using System.ComponentModel.DataAnnotations;

namespace app.webui.Models
{
    public class LoginModel
    {
        public string Username { get; set; }
        [Required]
        public string Email{get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}