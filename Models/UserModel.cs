using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebAPI_Lab07.Models
{

    public class AppUser : IdentityUser
    {
        
        [Required (ErrorMessage = "Name is required....")]
        [MaxLength(50, ErrorMessage = "Name between 1 and 50 chars")]
        public string Name { get; set; }
        [NotMapped]
        public IList<string> RoleNames { get; set; }
    }



}
