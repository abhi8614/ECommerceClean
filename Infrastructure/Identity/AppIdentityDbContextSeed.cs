using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Jay",
                    Email = "jay@test.com",
                    UserName = "jay@test.com",
                    Address = new Address
                    {
                        FirstName = "Jay",
                        LastName = "Gupta",
                        Street = "10 The street",
                        City = "Bhadohi",
                        State = "UP",
                        PinCode = "221402"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}