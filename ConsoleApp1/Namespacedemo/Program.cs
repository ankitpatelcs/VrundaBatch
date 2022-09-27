using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeOperations;

namespace Namespacedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.display();

            Console.Read();
        }
    }
}
