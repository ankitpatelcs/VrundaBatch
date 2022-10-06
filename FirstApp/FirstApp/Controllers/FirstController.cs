using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Index()
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid=1, fname="Vrunda", email="v@gmail.com" });
            li.Add(new Employee { empid=2, fname="Siddhi", email="v@gmail.com" });
            li.Add(new Employee { empid=3, fname="Chirag", email="v@gmail.com" });
            li.Add(new Employee { empid=4, fname="Parth", email="v@gmail.com" });

            return View(li);
        }

        public IActionResult RouteValues()
        {
            ViewBag.controller = RouteData.Values["controller"].ToString();
            ViewBag.action = RouteData.Values["action"].ToString();
            ViewBag.id = RouteData.Values["id"].ToString();
            return View();
        }
    }
}
