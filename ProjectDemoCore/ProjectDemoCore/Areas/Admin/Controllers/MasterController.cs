using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectDemoCore.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemoCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MasterController : Controller
    {
        private readonly ecommerceContext _context = null;
        private readonly IHttpContextAccessor _contextAccessor;
        public MasterController(ecommerceContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection fc)
        {
            string email = fc["email"];
            string pass = fc["password"];

            var data = _context.TblAdmins.Where(x => x.Email == email && x.Password == pass).FirstOrDefault();
            if (data != null)
            {
                _contextAccessor.HttpContext.Session.SetString("AdminId", data.AdminId.ToString());
                _contextAccessor.HttpContext.Session.SetString("AdminName", data.FName);
                return RedirectToAction("Dashboard");
            }
            ViewBag.loginerror = "Invalid Email or Password.!";
            return View();
        }
        public IActionResult Logout()
        {
            _contextAccessor.HttpContext.Session.Remove("AdminId");
            _contextAccessor.HttpContext.Session.Remove("AdminName");
            _contextAccessor.HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult Dashboard()
        {
            return View();
        }
        
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Tblproduct obj)
        {
            _context.Tblproducts.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("ManageProducts");
        }

        public IActionResult ManageProducts()
        {
            return View(_context.Tblproducts.ToList());
        }
    }
}
