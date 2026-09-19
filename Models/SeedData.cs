/*using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcUser.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Data.MvcUserContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<Data.MvcUserContext>>()))
        {
            // Look for any users.
            if (context.User.Any())
            {
                return;   // DB has been seeded
            }
            context.User.AddRange(
                new User
                {
                    Id = 1,
                    Username = "When Harry Met Sally",
                    HashedPassword = "When Harry Met Sally",
                    IsDarkMode = false
                }
            );
            context.SaveChanges();
        }
    }
}
*/