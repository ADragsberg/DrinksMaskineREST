using DrinksMaskineREST.Models;
using DrinksMaskineREST.Repos;
using Microsoft.AspNetCore.Mvc;

namespace DrinksMaskineREST.Controllers
{
    public class DrinkModelController : Controller
    {
        private IDrinkRepository _drinkRepo;

        public DrinkModelController(IDrinkRepository drinkRepo)
        {
            _drinkRepo = drinkRepo;
        }
        [HttpPost]
        public ActionResult<DrinkModel> Post([FromBody] DrinkModel drink)
        {
            try
            {
                _drinkRepo.Add(drink);
                return Ok(drink);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
