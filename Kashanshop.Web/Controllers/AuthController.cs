using Kashanshop.Domain.User;
using Kashanshop.Web.Models.news;
using Microsoft.AspNetCore.Mvc;

namespace Kashanshop.Web.Controllers;

public class AuthController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Login(LoginUserViewModel model)
    {
        if (ModelState.IsValid)
        {
            
        }
        
        
        return View(model);
    }

    public IActionResult Register()
    {
        var user = new UserViewModel()
        {
            Name = "Javad",
            Password = "12345",
            Username = "09225823932",
            ActivationStatus = UserStatus.Active,
            LastName = "jahantab",
            PhoneNumber = "09225823932"

        };
        return View();
    }
}