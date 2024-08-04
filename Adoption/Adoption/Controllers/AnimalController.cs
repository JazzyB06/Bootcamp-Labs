using Adoption.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Adoption.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AnimalController(AppDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SearchAnimals(string breedInput)
        {
            //SELECT * FROM Animals
            var animals = _dbContext.Animals.Where(x=>x.Breed == breedInput).ToList();
            return View(animals);
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Animal animal)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Animals.Add(animal);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(animal);
        }
        [HttpPost]
        public IActionResult Adopt(int id)
        {
            var animal = _dbContext.Animals.Find(id);
            if (animal != null)
            {
                _dbContext.Animals.Remove(animal);
                _dbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
