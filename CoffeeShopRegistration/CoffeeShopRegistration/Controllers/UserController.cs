using Microsoft.AspNetCore.Mvc;
using CoffeeShopRegistration.Models;

namespace CoffeeShopRegistration.Controllers;

public class UserController : Controller
{
    public IActionResult Register()
    {
        return View();
    }

    //The user on line 16 represent the data
    //Post means from the browser or client to the controller
    [HttpPost]
    public IActionResult RegisterUser(User user)
    {
        return View();
    }
}