using JsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JsDemo.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult nivos()
        {
            return View();
        }
        
        public IActionResult bvalid()
        {
            return View();
        }
        
        public IActionResult dataval()
        {
            return View();
        }
        [HttpPost]
        public IActionResult dataval([Bind("fname,mobile")]Employee obj)
        {
            return View();
        }
    }
}
