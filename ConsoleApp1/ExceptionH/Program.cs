using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionH
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 90;
                int b = 0;
                int c = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }
        }
    }
}
