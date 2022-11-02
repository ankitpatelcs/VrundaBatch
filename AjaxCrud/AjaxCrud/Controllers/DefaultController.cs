using AjaxCrud.EDM;
using Microsoft.AspNetCore.Mvc;

namespace AjaxCrud.Controllers
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
            return View();
        }

        public JsonResult GetEmployees()
        {
            return Json(dc.Tblemployees.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public string Create(Tblemployee obj)
        {
            dc.Tblemployees.Add(obj);
            dc.SaveChanges();
            return "Record Inserted.";
        }
        
        public IActionResult Edit(int id)
        {
            return View(dc.Tblemployees.Find(id));
        }

        [HttpPost]
        public string Edit(Tblemployee obj)
        {
            dc.Tblemployees.Update(obj);
            dc.SaveChanges();
            return "Record Updated.";
        }
        
        public IActionResult Delete(int id)
        {
            return View(dc.Tblemployees.Find(id));
        }

        [HttpPost,ActionName("Delete")]
        public string DeleteRec(int id)
        {
            dc.Tblemployees.Remove(dc.Tblemployees.Find(id));
            dc.SaveChanges();
            return "Record Deleted.";
        }
    }
}
