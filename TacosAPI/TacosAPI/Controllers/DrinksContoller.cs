using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TacosAPI.Models;
using TacosApp.Data;

namespace TacosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private readonly FastFoodTacoDbContext _fastFoodDrinkDB;

        public DrinksController(FastFoodTacoDbContext fastFoodDrinkDbContext)
        {
            _fastFoodDrinkDB = fastFoodDrinkDbContext;
        }

        // GET /Drinks
   
        [HttpGet]
        public IActionResult GetDrinks([FromQuery] string sortByCost)
        {
           
            var drinks = _fastFoodDrinkDB.Drinks.AsQueryable();

            if (!string.IsNullOrEmpty(sortByCost))
            {
                sortByCost = sortByCost.Trim().ToLower();

                
                if (string.Equals(sortByCost, "ascending"))
                {
                    drinks = drinks.OrderBy(d => d.Cost);
                }
                else if (string.Equals(sortByCost, "descending"))
                {
                    drinks = drinks.OrderByDescending(d => d.Cost);
                }
                else
                {
                    return BadRequest("Invalid sortByCost value. Use either 'ascending' or 'descending'.");
                }
            }

            return Ok(drinks.ToList());
        }

        // GET /Drinks/{id}
        [HttpGet("{id}")]
        public IActionResult GetDrink(int id)
        {
            try
            {
                var drink = _fastFoodDrinkDB.Drinks.FirstOrDefault(d => d.Id == id);

                if (drink == null)
                {
                    return NotFound();
                }

                return Ok(drink);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error. " + ex.Message);
            }
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

            drink.Id = _fastFoodDrinkDB.Drinks.Any() ? _fastFoodDrinkDB.Drinks.Max(d => d.Id) + 1 : 1;
            _fastFoodDrinkDB.Drinks.Add(drink);

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

            var drink = _fastFoodDrinkDB.Drinks.FirstOrDefault(d => d.Id == id);

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

