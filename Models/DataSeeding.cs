using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnlineResume.Data;

namespace OnlineResume.Models
{
    public class DataSeeding
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new OnlineResumeContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<OnlineResumeContext>>()))
            {
                // Look for any movies.
                if (context.ProjectModel.Any())
                {
                    return;   // DB has been seeded
                }
                context.ProjectModel.AddRange(
                    new ProjectModel
                    {
                        Name = "Online Resume",
                        Description = "an online resume create by using .NET Core MVC framework",
                        Author = "Trung Nguyen",
                        ProjectLink = "",
                        CreatedDate = DateTime.Parse("03-30-2023")
                    },
                    new ProjectModel
                    {
                        Name = "Spaceship Shooter",
                        Description = "an Space-Invader like game project.\nThis project is a group-project in RMIT Game Dev Group",
                        Author = "Trung Nguyen",
                        ProjectLink = "https://github.com/TrungNguyen999/SpaceshipShooter",
                        CreatedDate = DateTime.Parse("03-30-2023")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
