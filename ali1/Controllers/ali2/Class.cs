using Microsoft.AspNetCore.Mvc;

namespace MyFirstASPNetApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}