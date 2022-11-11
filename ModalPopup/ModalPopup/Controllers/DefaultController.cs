using Microsoft.AspNetCore.Mvc;
using ModalPopup.EDM;

namespace ModalPopup.Controllers
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
    }
}
