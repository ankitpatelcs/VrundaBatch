using EDMCrud.EDM;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDMCrud.Controllers
{
    public class DefaultController : Controller
    {
        private CompanyContext dc = null;
        public DefaultController(CompanyContext _dc)
        {
            dc = _dc;
        }
        public IActionResult Index()
        {
            return View(dc.Tblemployees.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tblemployee obj)
        {
            dc.Tblemployees.Add(obj);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult EditEmp(int id)
        {
            return View(dc.Tblemployees.Find(id));
        }
        [HttpPost]
        public IActionResult EditEmp(Tblemployee obj)
        {
            dc.Tblemployees.Update(obj);
            dc.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(dc.Tblemployees.Find(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteRec(int id)
        {
            dc.Tblemployees.Remove(dc.Tblemployees.Find(id));
            dc.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(dc.Tblemployees.Find(id));
        }
    }
}
