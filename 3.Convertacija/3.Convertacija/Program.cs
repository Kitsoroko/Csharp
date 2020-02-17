using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Convertacija
{
    class Program
    {
        //Конвертация
        //Класс convert
        static void Main(string[] args)

        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //команда для перевода русской клавиатуры
            string str1 = "1";
            string str2 = "2";
            Console.WriteLine(str1+str2);
            int a = 1;
            int b = 2;
            Console.WriteLine(a+b);
            int a1 = Convert.ToInt32(str1);
            Console.WriteLine(a1);
            
        }
    }
}
