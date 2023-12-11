using DrinksMaskineREST.Models;
using DrinksMaskineREST.Repos;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DrinksMaskineREST.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowAllPolicy")]
    [ApiController]
    public class OpskriftController : ControllerBase
    {
        private IDrinkRepository _drinkRepository;

        public OpskriftController(IDrinkRepository drinkRepo)
        {
            _drinkRepository = drinkRepo;

        }

        // GET api/<OpskriftController>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        public ActionResult<Opskrift> Get()
        {
            if (OpskriftRepo.opskrift == null)
            {
                NotFound();
            }
            return Ok(OpskriftRepo.opskrift);
        }

        // POST api/<OpskriftController>
        [HttpPost("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post(int id)
        {
            try
            {
                DrinkModel drink = _drinkRepository.GetById(id);

                OpskriftRepo.opskrift = new Opskrift(drink);
                return Ok(OpskriftRepo.opskrift);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
