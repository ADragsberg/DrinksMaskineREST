using DrinksMaskineREST.Models;
using Microsoft.EntityFrameworkCore;

namespace DrinksMaskineREST.Repos
{
    public class DrinkDBRepository : IDrinkRepository
    {
        private DbContext _drinkDbContext;
        public DrinkDBRepository(DbContext dbContext)
        {
            _drinkDbContext = dbContext;
        }

        public DrinkModel Add(DrinkModel drink)
        {
            drink.Validate();
            _drinkDbContext.Add(drink);
            _drinkDbContext.SaveChanges();
            return drink;
        }
    }
}
