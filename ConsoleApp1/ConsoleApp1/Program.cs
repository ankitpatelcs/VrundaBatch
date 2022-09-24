using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        int id;
        string name;
        //public Employee(int id, string name)
        //{
        //    this.id = id;
        //    this.name = name;
        //}
        protected void GetData()
        {
            Console.Write("Enter ID: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            name = Console.ReadLine();
        }
        protected void ShowData()
        {
            Console.WriteLine($"Employee ID: {id}");
            Console.WriteLine($"Employee Name: {name}");
        }
        //~Employee()
        //{

        //}
    }
    class Payroll : Employee
    {
        int salary;
        internal void GetPayroll()
        {
            GetData();
            Console.Write("Enter Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        internal void ShowPayroll()
        {
            ShowData();
            Console.WriteLine($"Salary: {salary}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payroll p = new Payroll();
            p.GetPayroll();
            p.ShowPayroll();


            Console.Read();
        }
    }
}
