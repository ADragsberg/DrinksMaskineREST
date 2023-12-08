using DrinksMaskineREST.Models;

namespace DrinksMaskineREST.Repos
{
    public interface IDrinkRepository
    {
        IEnumerable<DrinkModel> GetAll(string? name = null);
        DrinkModel GetById(int id);

        DrinkModel Add(DrinkModel drink);
        bool Update(int id, DrinkModel drink);

        bool Delete(int id);    
    }
}
