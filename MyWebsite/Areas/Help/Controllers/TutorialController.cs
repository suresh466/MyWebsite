using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace MyWebsite.Area.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        [HttpGet]
        [Route("Help/Tutorial/Index/Page{id=1}")]
        public IActionResult Index(int id)
        {
            // Determine the view based on the id
            switch (id)
            {
                case 1:
                    return View("Page1");
                case 2:
                    return View("Page2");
                case 3:
                    return View("Page3");
                default:
                    // Return a default view or an error view if the id is not 1, 2, or 3
                    return View("Error");
            }
        }
    }
}
