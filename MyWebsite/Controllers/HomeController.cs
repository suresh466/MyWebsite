using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebsite.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Attribute based routing for the pages
        [HttpGet]
        [Route("Home/About")]
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        [Route("Home/Contact")]
        public IActionResult Contact()
        {
            var contactInfo = new Dictionary<string, string>
    {
        {"PhoneNumber", "123-456-7890"},
        {"Email", "contact1@mywebsite.com"},
        {"FacebookUrl", "https://facebook.com/mywebsite"}
    };
            //Sending a collection of contact information to the view
            ViewBag.Contact = contactInfo;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
