using Microsoft.AspNetCore.Mvc;

namespace ViewComponentDemo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
