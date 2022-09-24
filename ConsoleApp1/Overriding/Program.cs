using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class Employee
    {
        virtual public void display()
        {
            Console.WriteLine("calling from Employee");
        }
    }
    class Payroll: Employee
    {
        override public void display()
        {
            Console.WriteLine("calling from Payroll");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Payroll();
            e.display();

            Console.Read();
        }
    }
}
