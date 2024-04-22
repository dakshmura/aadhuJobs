using aadhu.Models;
using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    // GET: /Account/Login
    public ActionResult Login()
    {
        return View();
    }

    // POST: /Account/Login
    [HttpPost]
    public ActionResult Login(UserDetails model)
    {
        if (ModelState.IsValid)
        {
            // Authenticate user (Check username and password)
            // For demonstration, let's assume authentication is successful
            return RedirectToAction("Index", "Home");
        }
        return View(model);
    }

    // GET: /Account/Register
    public ActionResult Register()
    {
        return View();
    }

    // POST: /Account/Register
    [HttpPost]
    public ActionResult Register(UserDetails model)
    {
        if (ModelState.IsValid)
        {
            // Save the user to the database or perform necessary actions
            // For demonstration, let's assume registration is successful
            return RedirectToAction("Login");
        }
        return View(model);
    }
}
