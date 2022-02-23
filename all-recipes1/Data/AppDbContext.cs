using all_recipes1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace all_recipes1.Data
{
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
