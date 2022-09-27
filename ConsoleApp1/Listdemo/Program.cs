using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listdemo
{
    class Employee
    {
        internal int id;
        internal string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { id=1,name="Vrunda" });
            li.Add(new Employee { id=2,name="Chirag" });
            li.Add(new Employee { id=3,name="Disha" });
            li.Add(new Employee { id=4,name="Gopi" });

            foreach (var item in li)
            {
                Console.WriteLine($"ID: {item.id}");
                Console.WriteLine($"Name: {item.name}");
            }

            Console.ReadLine();
        }
    }
}
