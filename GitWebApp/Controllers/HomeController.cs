using GitWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace GitWebApp.Controllers
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
            //return View();

            var name = "Joel Mensah";
            return Json(new { Name = name });

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}