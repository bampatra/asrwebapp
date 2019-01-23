using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace ASRWebApp.Data
{
    public static class SeedData
    {
        public static async Task Initialise(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var roles = new[] { Constants.StudentRole, Constants.StaffRole };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                    await roleManager.CreateAsync(new IdentityRole { Name = role });
            }

            var userManager = serviceProvider.GetService<UserManager<IdentityUser>>();
            await CreateUserAndEnsureUserHasRole(userManager, "staff@example.com", Constants.StaffRole);
            await CreateUserAndEnsureUserHasRole(userManager, "student@example.com", Constants.StudentRole);
            //await EnsureUserHasRole(userManager, "s3549111@student.rmit.edu.au", Constants.StudentRole);
        }

        private static async Task CreateUserAndEnsureUserHasRole(
            UserManager<IdentityUser> userManager, string userName, string role)
        {
            if (await userManager.FindByNameAsync(userName) == null)
                await userManager.CreateAsync(new IdentityUser { UserName = userName, Email = userName }, "abc123");
            await EnsureUserHasRole(userManager, userName, role);
        }

        private static async Task EnsureUserHasRole(UserManager<IdentityUser> userManager, string userName, string role)
        {
            var user = await userManager.FindByNameAsync(userName);
            if (user != null && !await userManager.IsInRoleAsync(user, role))
                await userManager.AddToRoleAsync(user, role);
        }
    }
}
