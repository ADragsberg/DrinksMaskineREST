using DrinksMaskineREST.Models;
using DrinksMaskineREST.Repos;
using Microsoft.AspNetCore.Mvc;

namespace DrinksMaskineREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinkModelController : ControllerBase
    {
        private IDrinkRepository _drinkRepo;

        public DrinkModelController(IDrinkRepository drinkRepo)
        {
            _drinkRepo = drinkRepo;
        }
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
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

        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<DrinkModel> Put(int id,[FromBody]DrinkModel drink)
        {
            try
            {
                
                bool isUpdated =_drinkRepo.Update(id,drink);
                if (isUpdated)
                {
                    return Ok(isUpdated);
                }
                else
                {
                    return BadRequest("Drinken blev ikke fundet");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
