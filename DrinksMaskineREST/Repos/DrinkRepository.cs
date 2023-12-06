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

        public bool Delete(int id, DrinkModel drinkToDelete)
        {

            if (_drinks.ContainsKey(drinkToDelete.Id))
            {
                _drinks.Remove(drinkToDelete.Id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Update(int id, DrinkModel newDrink)
        {

            return true;
        }

        private int NextId()
        {
            return _count > 0 ? GetAll().Select(x => x.Id).Max() + 1 : 1;
        }

        public DrinkModel GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
