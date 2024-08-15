using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TacosAPI.Models;

namespace TacosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Drinks : ControllerBase
    {
        private static readonly List<Drink> _drinks = new List<Drink>();

        // GET /Drinks
        [HttpGet]
        public IActionResult GetDrinks([FromQuery] string sortByCost)
        {
            var drinks = _drinks.AsEnumerable();

            if (sortByCost.ToLower() == "ascending")
            {
                drinks = drinks.OrderBy(d => d.Cost);
            }
            else if (sortByCost.ToLower() == "descending")
            {
                drinks = drinks.OrderByDescending(d => d.Cost);
            }
            else if (sortByCost != null) 
            {
                return BadRequest("Invalid sortByCost value. Use either 'ascending' or 'descending'.");
            }

            return Ok(drinks.ToList());
        }

        // GET /Drinks/{id}
        [HttpGet("{id}")]
        public IActionResult GetDrink(int id)
        {
            var drink = _drinks.FirstOrDefault(d => d.Id == id);

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
                return BadRequest("Drink data is required.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
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
                return BadRequest("There's a mismatch between ID in the URL and ID in the body.");
            }

            var drink = _drinks.FirstOrDefault(d => d.Id == id);

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

