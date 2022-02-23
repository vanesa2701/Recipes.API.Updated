using all_recipes1.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace all_recipes1.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Recipes.Any())
                {
                    context.Recipes.AddRange(new Recipe()
                    {
                        Name = "1st Recipe Name",
                        Description = "1st Recipe Description",
                        IsCooked = true,
                        DateCooked = System.DateTime.Now.AddDays(-10),
                        Rate = 7,
                        Category = "Sweets",
                        Ingredients = "Flavour, sugar, eggs, milk",
                        CookingTime = 60,
                        DateAdded = System.DateTime.Now,
                        CoverUrl = "Https....",
                    },
                    new Recipe()
                    {
                        Name = "2nd Recipe Name",
                        Description = "2nd Recipe Description",
                        IsCooked = false,
                        Category = "Sweets",
                        Ingredients = "Flavour, sugar, eggs, milk",
                        CookingTime = 60,
                        DateAdded = System.DateTime.Now,
                        CoverUrl = "Https....",
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
