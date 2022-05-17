using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks; 

namespace Ysk.Todo.Web.Identity
{
    public static class IdentityInitializer
    {
        public static async Task SeedData(UserManager<Entities.Concrete.AppUser> userManager,RoleManager<Entities.Concrete.AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if (adminRole == null)
            {
                await roleManager.CreateAsync(new Entities.Concrete.AppRole { Name = "Admin" });
            }

            var memberRole = await roleManager.FindByNameAsync("Member");
            if (memberRole == null)
            {
                await roleManager.CreateAsync(new Entities.Concrete.AppRole { Name = "Member" });
            }

            var adminUser = await userManager.FindByNameAsync("emre");
            if (adminUser == null)
            {
                Entities.Concrete.AppUser user = new Entities.Concrete.AppUser { Name = "Emre", Surname = "Aktürk", UserName = "emre", Email = "emre@gmail.com" };
                await userManager.CreateAsync(user,"1");
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
