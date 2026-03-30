using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home
        public IActionResult Index()
        {
            return View();
        }
    }
}