using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace WebAPI_Lab07.Models
{
    public class RegisterViewModel
    {
        [Required (ErrorMessage ="Enter User Name!!")]
        [StringLength(255)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(255)]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password!!")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]

        public string Password { get; set; }
        [Required(ErrorMessage = "Confirm Password!!")]
        [DataType(DataType.Password)]
        [Display(Name = "ConfirmPassword")]
        public string ConfirmPassword { get; set; }
    }
}
