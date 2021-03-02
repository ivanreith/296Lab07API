using System.ComponentModel.DataAnnotations;

namespace WebAPI_Lab07.Models
{
    public class LogInViewModel
    {
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(255)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(255)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }

    }
}
