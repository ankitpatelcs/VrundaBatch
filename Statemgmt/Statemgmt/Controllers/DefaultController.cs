using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Statemgmt.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public DefaultController(IHttpContextAccessor accessor)
        {
            _httpContextAccessor = accessor;
        }
        public IActionResult Index()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTimeOffset.Now.AddDays(2);
            _httpContextAccessor.HttpContext.Response.Cookies.Append("uname", "Vrunda", options);
            return View();
        }

        public IActionResult SendMsg(string msg)
        {
            ViewBag.msg = msg;
            return View();
        }

        public IActionResult create()
        {
            _httpContextAccessor.HttpContext.Session.SetString("uname", "vrunda");
            return View();
        }

        public IActionResult next()
        {
            return View();
        }
        public IActionResult svar()
        {
            ViewBag.message = "from viewbag";
            ViewData["msg"] = "from ViewData";

            TempData["info"] = "from TempData";
            return View();
        }
        public IActionResult second()
        {
            return View();
        }
    }
}
