using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TunuTarnar_restaurant.Models;

namespace TunuTarnar_restaurant.Controllers
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

        public IActionResult Slider_Show() {
            return View();
        } 
        public IActionResult Slider_Dot() {
            return View();
        }

        public IActionResult Image_Slider() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
