using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Area.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
