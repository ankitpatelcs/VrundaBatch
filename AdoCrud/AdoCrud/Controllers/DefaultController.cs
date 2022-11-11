﻿using AdoCrud.Services;
using EDMCrud.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoCrud.Controllers
{
    public class DefaultController : Controller
    {
        EmployeeService dc = new EmployeeService();
        // GET: Default
        public ActionResult Index()
        {
            return View(dc.GetAllEmployees());
        }
        public ActionResult WGrid()
        {
            return View(dc.GetAllEmployees());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblemployee obj)
        {
            dc.AddEmployee(obj);
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            return View(dc.GetEmployeeById(id));
        }
        public ActionResult Edit(int id)
        {
            return View(dc.GetEmployeeById(id));
        }
        [HttpPost]
        public ActionResult Edit(tblemployee obj)
        {
            dc.UpdateEmployee(obj);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            return View(dc.GetEmployeeById(id));
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteRec(int id)
        {
            dc.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
    }
}