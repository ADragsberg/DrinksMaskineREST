using DrinksMaskineREST.Models;
using System.Runtime.CompilerServices;

namespace DrinksMaskineREST.Repos
{
    public class DrinkRepository : IDrinkRepository
    {
        private Dictionary<string, DrinkAPIModel> _drinks = new Dictionary<string, DrinkAPIModel>();
        private int _count = 1;
        public DrinkRepository() 
        {

            // hardcoded data

        }



        public DrinkAPIModel Add(DrinkAPIModel drink)
        {
            drink.Validate();
            drink.idDrink = NextId();
            _drinks.Add(drink.idDrink, drink);
            return drink;
        }

        private string NextId()
        {
            string nextId = _count.ToString(); 
            _count++;
            return nextId;
        }
    }
}
