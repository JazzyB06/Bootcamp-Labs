﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TacosAPI.Models;

namespace TacosAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TacosController : ControllerBase
    {
        
        private static List<Taco> _tacos = new List<Taco>(); 

        // GET /Tacos
        [HttpGet]
        public IActionResult GetTacos([FromQuery] bool? softShell)
        {
            var filteredTacos = new List<Taco>(_tacos);

            if (softShell.HasValue)
            {
                filteredTacos = filteredTacos.Where(t => t.SoftShell == softShell.Value).ToList();
            }

            return Ok(filteredTacos);
        }

        // GET /Tacos/{id}
        [HttpGet("{id}")]
        public IActionResult GetTaco(int id)
        {
            var taco = _tacos.Find(t => t.Id == id);

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
                return BadRequest();
            }

            taco.Id = _tacos.Any() ? _tacos.Max(t => t.Id) + 1 : 1;
            _tacos.Add(taco);

            return CreatedAtAction(nameof(GetTaco), new { id = taco.Id }, taco);
        }

        // DELETE /Tacos/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteTaco(int id)
        {
            var taco = _tacos.Find(t => t.Id == id);

            if (taco == null)
            {
                return NotFound();
            }

            _tacos.Remove(taco);

            return NoContent();
        }
    }
}