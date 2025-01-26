using Microsoft.AspNetCore.Mvc;

namespace LandingPage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
