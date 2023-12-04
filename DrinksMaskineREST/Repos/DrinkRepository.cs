using DrinksMaskineREST.Models;
using System.Runtime.CompilerServices;

namespace DrinksMaskineREST.Repos
{
    public class DrinkRepository : IDrinkRepository
    {
        private Dictionary<int, DrinkAPIModel> _drinks = new Dictionary<int, DrinkAPIModel>();
        private int _count = 1;
        public DrinkRepository() 
        {

            // hardcoded data

        }



        public DrinkAPIModel Add(DrinkAPIModel drink)
        {
            drink.Validate();
            drink.Id = NextId();
            _drinks.Add(drink.Id, drink);
            return drink;
        }

        public List<DrinkAPIModel> GetAll()
        {
            List<DrinkAPIModel> result = new List<DrinkAPIModel>(_drinks.Values);
            return result;

        }

        private int NextId()
        {
            return _count > 0 ? GetAll().Select(x => x.Id).Max() + 1 : 1;
        }
    }
}
