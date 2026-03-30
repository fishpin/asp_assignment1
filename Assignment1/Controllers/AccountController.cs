using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }
    }
}
