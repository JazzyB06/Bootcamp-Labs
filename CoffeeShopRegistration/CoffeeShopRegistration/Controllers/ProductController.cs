using Microsoft.AspNetCore.Mvc;
using CoffeeShopRegistration.Models;
using CoffeeShopRegistration.Models.Data;

namespace CoffeeShopRegistration.Controllers
{
	public class ProductController : Controller
	{
		private ApplicationDbContext _dbContext;
		public ActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public IActionResult RegisterUser(Product product)
		{
			_dbContext.Add(product);

			_dbContext.SaveChanges();

			return RedirectToAction("Index", "Home");
		}
	}
}