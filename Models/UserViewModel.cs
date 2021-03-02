using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace WebAPI_Lab07.Models
{
    public class UserViewModel
    {
        public IEnumerable<AppUser> Users { get; set; }
        public IEnumerable<IdentityRole> Roles { get; set; }
    }
}
