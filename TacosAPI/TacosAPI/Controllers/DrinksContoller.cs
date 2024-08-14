using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TacosAPI.Models;

namespace TacosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Drinks : ControllerBase
    {
        private static List<Drink> _drinks = new List<Drink>();

        [HttpGet]
        public IActionResult GetDrinks([FromQuery] string sortByCost)
        {
            var drinks = _drinks.AsEnumerable(); 

            if (sortByCost == "ascending")
            {
                drinks = drinks.OrderBy(d => d.Cost);
            }
            else if (sortByCost == "descending")
            {
                drinks = drinks.OrderByDescending(d => d.Cost);
            }

            return Ok(drinks.ToList());
        }

        // GET /Drinks/{id}
        [HttpGet("{id}")]
        public IActionResult GetDrink(int id)
        {
            var drink = _drinks.Find(d => d.Id == id);

            if (drink == null)
            {
                return NotFound();
            }

            return Ok(drink);
        }

        // POST /Drinks
        [HttpPost]
        public IActionResult CreateDrink([FromBody] Drink drink)
        {
            if (drink == null)
            {
                return BadRequest();
            }
            drink.Id = _drinks.Any() ? _drinks.Max(d => d.Id) + 1 : 1;
            _drinks.Add(drink);

            return CreatedAtAction(nameof(GetDrink), new { id = drink.Id }, drink);
        }

        // PUT /Drinks/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateDrink(int id, [FromBody] Drink updatedDrink)
        {
            if (updatedDrink == null || id != updatedDrink.Id)
            {
                return BadRequest();
            }

            var drink = _drinks.Find(d => d.Id == id);

            if (drink == null)
            {
                return NotFound();
            }

            drink.Name = updatedDrink.Name;
            drink.Cost = updatedDrink.Cost;

            return Ok(drink);
        }
    }
}
