using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TacosAPI.Models;
using TacosApp.Data;

namespace TacosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacosController : ControllerBase
    {
        private readonly FastFoodTacoDbContext _fastFoodTacoDB;

        public TacosController(FastFoodTacoDbContext fastFoodTacoDbContext)
        {
            _fastFoodTacoDB = fastFoodTacoDbContext;
        }

        // GET /Tacos
        [HttpGet]
        public IActionResult GetTacos([FromQuery] bool? isSoftShell)
        {

            if (isSoftShell != null)
            {
                return Ok(_fastFoodTacoDB.Tacos.Where(x => x.SoftShell == isSoftShell).ToList());
            }


            return Ok(_fastFoodTacoDB.Tacos.ToList());
        }

        // GET /Tacos/{id}
        [HttpGet("{id}")]
        public IActionResult GetTaco(int id)
        {
            var taco = _fastFoodTacoDB.Tacos.Find(id);

            if (taco == null)
            {
                return NotFound();
            }

            return Ok(taco);
        }

        // POST /Tacos
        [HttpPost]
        public IActionResult CreateTaco([FromBody] Taco taco)
        {
            if (taco == null)
            {
                return BadRequest("Taco data is required.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            taco.Id = _fastFoodTacoDB.Tacos.Any() ? _fastFoodTacoDB.Tacos.Max(t => t.Id) + 1 : 1;
            _fastFoodTacoDB.Tacos.Add(taco);
            _fastFoodTacoDB.SaveChanges();

            return CreatedAtAction(nameof(GetTaco), new { id = taco.Id }, taco);
        }

        // DELETE /Tacos/{id}
        [HttpDelete("{id}")]

        public IActionResult DeleteTaco(int id)
        {
            // Find the taco by ID
            var taco = _fastFoodTacoDB.Tacos.FirstOrDefault(t => t.Id == id);

            if (taco == null)
            {
                return NotFound();
            }

            try
            {
               
                _fastFoodTacoDB.Tacos.Remove(taco);

              
                _fastFoodTacoDB.SaveChanges();
            }
            catch (Exception ex)
            {
                
                return StatusCode(500, "Internal server error. " + ex.Message);
            }

            return NoContent();
        }
    }
}