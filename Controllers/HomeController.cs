using Microsoft.AspNetCore.Mvc;
using ModelViewControllerDemo.Models;
using System.Diagnostics;

namespace ModelViewControllerDemo.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Niketh()
        {
            return View();
        }
        public IActionResult Pankaj()
        {
            return new ContentResult
            {
                ContentType = "text/html",
                Content = "<b>Hello Pankaj<b>"
            };

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
