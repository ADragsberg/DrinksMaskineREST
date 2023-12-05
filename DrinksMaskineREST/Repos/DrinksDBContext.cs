using DrinksMaskineREST.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinksMaskineREST.Repos
{
    public class DrinksDBContext : DbContext
    {
        public DrinksDBContext(DbContextOptions<DrinksDBContext> options) : base(options)
        {          
        }

        public DbSet<DrinkAPIModel> drinkAPIModels { get; set; }
    }
}
