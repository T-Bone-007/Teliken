using Microsoft.AspNetCore.Mvc;
using Pravis_Teliken.Models;
using System.Diagnostics;

namespace Pravis_Teliken.Controllers
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
        public IActionResult Inlog()
        {
            return View();
        }
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult Agenda()
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
