using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Area.Help.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
