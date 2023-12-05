using DrinksMaskineREST.Models;

namespace DrinksMaskineREST.Repos
{
    public interface IDrinkRepository
    {
        DrinkModel Add(DrinkModel drink);
    }
}
