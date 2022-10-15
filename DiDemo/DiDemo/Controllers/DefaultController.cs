using DiDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiDemo.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IVisitorCounter _counter;
        public DefaultController(IVisitorCounter counter)
        {
            _counter = counter;
        }
        public IActionResult Index([FromServices]IVisitorCounter _cnt)
        {
            ViewBag.count = _counter.GetCount();
            ViewBag.cnt = _cnt.GetCount();
            return View();
        }
    }
}
