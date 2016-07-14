using System.ComponentModel.DataAnnotations;

namespace OAUTH.AuthenticationServer.Web.Models
{
    public class LoginModel
    {
        [Display(Name = "User Name")]
        [Required]
        [StringLength(250)]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required]
        [StringLength(250)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}