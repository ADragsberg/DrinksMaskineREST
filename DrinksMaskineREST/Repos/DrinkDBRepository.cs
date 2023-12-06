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

        public bool Update(int id, DrinkModel newDrink)
        {
            newDrink.Validate();

            DrinkModel drink = GetById(id);

            drink.strDrink = newDrink.strDrink;
            drink.strCategory = newDrink.strCategory;
            drink.strAlcoholic = newDrink.strAlcoholic;
            drink.strIngredient1 = newDrink.strIngredient1;
            drink.strIngredient2 = newDrink.strIngredient2;
            drink.strIngredient3 = newDrink.strIngredient3;
            drink.strIngredient4 = newDrink.strIngredient4;
            drink.strIngredient5 = newDrink.strIngredient5;
            drink.strIngredient6 = newDrink.strIngredient6;
            drink.strMeasure1 = newDrink.strMeasure1;
            drink.strMeasure2 = newDrink.strMeasure2;
            drink.strMeasure3 = newDrink.strMeasure3;
            drink.strMeasure4 = newDrink.strMeasure4;
            drink.strMeasure5 = newDrink.strMeasure5;
            drink.strMeasure6 = newDrink.strMeasure6;
            drink.strInstructions = newDrink.strInstructions;
            drink.strDrinkThumb = newDrink.strDrinkThumb;
            drink.strImageSource = newDrink.strImageSource;
            drink.Creator = newDrink.Creator;
            _drinkDbContext.SaveChanges();
            return true;
        }

        public bool Delete(int id, DrinkModel drinkToDelete)
        {
            
            DrinkModel drink = GetById(id);
            
            _drinkDbContext.Remove(drink);
            _drinkDbContext.SaveChanges();
            return true;
            
        }

        public List<DrinkModel> GetAll()
        {
            List<DrinkModel> result = new List<DrinkModel>(_drinkDbContext.Set<DrinkModel>());
            return result;

        }

        public DrinkModel GetById(int id)
        {
            DrinkModel? result = _drinkDbContext.Set<DrinkModel>().Find(id);
            if (result == null)
                throw new Exception("Drink not found in Database");
            return result;
        }
    }
}
