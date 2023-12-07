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
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<List<DrinkModel>> Get()
        {
            List<DrinkModel> drinks = new List<DrinkModel>(_drinkRepo.GetAll());

            if (drinks.Count == 0 )
                return NotFound();

            return Ok(drinks);
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
                
                bool isUpdated =_drinkRepo.Update(id, drink);
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


        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Delete(int id)
        {
            try
            {
                bool isDeleted = _drinkRepo.Delete(id);
                if (isDeleted)
                {
                    return Ok(isDeleted);
                }
                else
                {
                    return NotFound("Drinken blev ikke funet");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
