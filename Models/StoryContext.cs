
using Microsoft.EntityFrameworkCore;


namespace WebAPI_Lab07.Models
{
    public class StoryContext : DbContext
    {
       // public StoryContext()
       // {
       // }

        public StoryContext(DbContextOptions<StoryContext>  options)
            : base(options) { }
        public DbSet<CommentModel> Comments { get; set; }
        public DbSet<StoriesModelForm> Story { get; set; }
        public DbSet<AppUser> AppUser { get; set; } //REmoved due to Identity inheritance, parent class would do it
/*
        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            UserManager<AppUser> userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string username = "admin";
            string password = "Sesame@1";
            string roleName = "Admin";
            // Creating the role the first time
            if (await roleManager.FindByNameAsync(roleName)== null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
            // creating the username the first time and adding it to the role
            if (await userManager.FindByNameAsync(username) == null)
            {
                AppUser user = new AppUser { UserName = username };
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }

            }

        }  */

     
        
    }
}