using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Area.Help.Controllers
{
    public class TutorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
