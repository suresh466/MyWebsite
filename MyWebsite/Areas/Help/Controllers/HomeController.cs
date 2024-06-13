using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Area.Help.Controllers
{
    [Area("Help")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
