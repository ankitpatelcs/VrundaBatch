using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectDemoCore.EDM;
using ProjectDemoCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectDemoCore.Areas.Users.Controllers
{
    [Area("Users")]
    public class DefaultController : Controller
    {
        private readonly ecommerceContext _context = null;
        private readonly IHttpContextAccessor _contextAccessor;
        public DefaultController(ecommerceContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }
        public IActionResult HomePage()
        {
            return View();
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

            var data = _context.TblUsers.Where(x => x.Email == email && x.Password == pass).FirstOrDefault();
            if (data != null)
            {
                _contextAccessor.HttpContext.Session.SetString("UserId", data.UserId.ToString());
                _contextAccessor.HttpContext.Session.SetString("UserName", data.FName);
                return RedirectToAction("HomePage");
            }
            ViewBag.loginerror = "Invalid Email or Password.!";
            return View();
        }

        public IActionResult Logout()
        {
            _contextAccessor.HttpContext.Session.Remove("UserId");
            _contextAccessor.HttpContext.Session.Remove("UserName");
            _contextAccessor.HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(IFormCollection fc)
        {
            return View();
        }

        public IActionResult Products()
        {
            return View(_context.Tblproducts.ToList());
        }

        public IActionResult Single(int id)
        {
            return View(_context.Tblproducts.Find(id));
        }

        public string AddToCart(int pid)
        {
            int userid = Convert.ToInt32(_contextAccessor.HttpContext.Session.GetString("UserId"));
            Tblcart obj = new Tblcart();
            obj.ProductId = pid;
            obj.Qty = 1;
            obj.UserId = userid;
            _context.Tblcarts.Add(obj);
            _context.SaveChanges();

            return "Product Added to Cart.";
        }

        public IActionResult Cart()
        {
            int userid = Convert.ToInt32(_contextAccessor.HttpContext.Session.GetString("UserId"));
            return View(_context.Tblcarts.Include(x=>x.Product).Where(x=>x.UserId==userid).ToList());
        }

        public IActionResult Checkout()
        {
            int userid = Convert.ToInt32(_contextAccessor.HttpContext.Session.GetString("UserId"));
            Tblorder obj = new Tblorder();
            obj.Orderdate = DateTime.Now;
            obj.Status = (byte)ProductStatusEnum.Confirmed;
            obj.UserId = userid;

            _context.Tblorders.Add(obj);
            _context.SaveChanges();

            //orderdetails
            Tblorderdetail objdetails;
            var cartdata = _context.Tblcarts.Where(x => x.UserId == userid).ToList();
            foreach (var item in cartdata)
            {
                objdetails = new Tblorderdetail();
                objdetails.OrderId = obj.OrderId;
                objdetails.ProductId = item.ProductId;
                objdetails.Qty = item.Qty;
                _context.Tblorderdetails.Add(objdetails);
                _context.SaveChanges();
            }

            return RedirectToAction("Success");
        }
        public IActionResult Success()
        {
            return View();
        }
    }
}
