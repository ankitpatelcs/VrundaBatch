using ExceptionHandeling.Filters;
using ExceptionHandeling.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExceptionHandeling.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [CustomExceptionFilter]
        public IActionResult Index()
        {
            int a = 10;
            int b = 0;
            int c = a / b;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            var pathFeature = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            return View(pathFeature.Error);
        }
    }
}