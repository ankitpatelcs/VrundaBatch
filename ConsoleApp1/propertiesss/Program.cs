using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propertiesss
{
    class MyClass
    {
        int id;
        public int EmpID 
        {
            get 
            {
                return id;
            }
            set 
            {
                id = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.EmpID = 90;

            Console.WriteLine(m.EmpID);

            Console.Read();
        }
    }
}
