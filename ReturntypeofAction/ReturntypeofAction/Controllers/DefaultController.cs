using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReturntypeofAction.Controllers
{
    public class DefaultController : Controller
    {
        private IWebHostEnvironment _env;
        public DefaultController(IWebHostEnvironment env)
        {
            _env = env;
        }
        public ContentResult Index()
        {
            //return Content("Learning <b>.Net Core</b> from TOPS","text/html");
            return Content(_env.WebRootPath);
        }

        public ViewResult SendMsg(string msg)
        {
            ViewBag.msg = msg;
            return View();
        }

        public RedirectResult GotoUrl()
        {
            return Redirect("https://www.google.com");
        }
        public RedirectResult GotoNextUrl()
        {
            return RedirectPermanent("https://www.google.com");
        }

        public RedirectToActionResult GotoAbout()
        {
            return RedirectToAction("SendMsg",new { msg= "Calling RedirectToAction" });
        }

        public RedirectToRouteResult GotoRoute()
        {
            return RedirectToRoute("SendMsg");
        }

        public FileResult GetFile()
        {
            return File("/css/site.css","text/plain","CommonSite.css");
        }
    }
}
