using DrinksMaskineREST.Models;

namespace DrinksMaskineREST.Repos
{
    public interface IDrinkRepository
    {
        DrinkModel Add(DrinkModel drink);
        bool Update(int id, DrinkModel drink);

        bool Delete(int id, DrinkModel drink);    
    }
}
