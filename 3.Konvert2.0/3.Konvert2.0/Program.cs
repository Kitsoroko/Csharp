using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Konvert2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a, b;

            Console.WriteLine("Write number 1");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            Console.WriteLine("Write number 2");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);
            int result = a + b;
            Console.WriteLine("Sum a + b = " + result);
        }
    }
}
