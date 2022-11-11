using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using ViewComponentDemo.EDM;
using ViewComponentDemo.Models;

namespace ViewComponentDemo.Components
{
    public class EmployeeSummary : ViewComponent
    {
        private CompanyContext dc = null;
        public EmployeeSummary(CompanyContext _dc)
        {
            dc = _dc;
        }
        //public string Invoke()
        //{
        //    return $"Total Salary: {dc.Tblemployees.Sum(x=>x.Salary)}, Total Count: {dc.Tblemployees.Count()}";
        //}
        public IViewComponentResult Invoke(int salary)
        {
            return View(new EmployeeViewModel
            {
                EmployeeCount= dc.Tblemployees.Where(x=>x.Salary==salary).Count(),
                TotalSalary= dc.Tblemployees.Where(x => x.Salary == salary).Sum(x => x.Salary)
            });
        }
    }
}
