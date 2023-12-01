using DrinksMaskineREST.Models;
using System.Runtime.CompilerServices;

namespace DrinksMaskineREST.Repos
{
    public class DrinkRepository : IDrinkRepository
    {
        private Dictionary<int, Drink> _drinks;
        public DrinkRepository() 
        {

            // hardcoded data
            _drinks = new Dictionary<int, Drink>();
        }

        public Drink Add()
        {
            throw new NotImplementedException();
        }
    }
}
