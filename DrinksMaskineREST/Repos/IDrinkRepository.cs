using DrinksMaskineREST.Models;

namespace DrinksMaskineREST.Repos
{
    public interface IDrinkRepository
    {
        DrinkAPIModel Add(DrinkAPIModel drink);
    }
}
