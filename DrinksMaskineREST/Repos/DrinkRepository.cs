using DrinksMaskineREST.Models;
using System.Runtime.CompilerServices;

namespace DrinksMaskineREST.Repos
{
    public class DrinkRepository : IDrinkRepository
    {
        private Dictionary<int, DrinkModel> _drinks = new Dictionary<int, DrinkModel>();
        private int _count = 1;
        public DrinkRepository() 
        {

            // hardcoded data

        }



        public DrinkModel Add(DrinkModel drink)
        {
            drink.Validate();
            drink.Id = NextId();
            _drinks.Add(drink.Id, drink);
            return drink;
        }

        public List<DrinkModel> GetAll()
        {
            List<DrinkModel> result = new List<DrinkModel>(_drinks.Values);
            return result;

        }

        public bool Delete(int id)
        {

            if (_drinks.ContainsKey(id))
            {
                _drinks.Remove(id);
                return true;
            }
            else
            {
                return false;
            }
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
            return true;
        }

        private int NextId()
        {
            return _count++;
        }

        public DrinkModel GetById(int id)
        {
            if (_drinks.ContainsKey(id))
            {
                DrinkModel result = _drinks[id];
                return result;
            }
            else
                throw new Exception("Drink findes ikke i repository");
        }
    }
}
