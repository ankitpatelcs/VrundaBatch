using Microsoft.AspNetCore.Mvc;

namespace ConfigFileAccess.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IConfiguration _configuration;
        public DefaultController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            ViewBag.SMTPServer = _configuration["MyApplicationKey:SMTPServer"];
            ViewBag.AzureSQLServerURL = _configuration["MyApplicationKey:AzureSQLServerURL"];
            ViewBag.ImagePath = _configuration["MyApplicationKey:ImagePath"];
            return View();
        }
    }
}
