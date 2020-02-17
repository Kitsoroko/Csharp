using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {

            // Программа будет проверять ваши числа на четность и нечетность!
            Console.WriteLine("Введите целое число: ");
            //int a = 0;
            //a++;
            //int b=1;
            //b++;
            int value;
            value = Int32.Parse(Console.ReadLine());
            int ostatok = value % 2;

            if (ostatok != 0)
            {
                Console.WriteLine("Ваше число не является четным: " + value);
            }
            else //(value == b) 
            {
                Console.WriteLine("Ваше число- четное: " + value);
            }
            
            /*
            int x;
            for (x = 0; x < 5; x++)
            {
                string imja = Console.ReadLine();
                string Denis = ("Denis");
                if (imja == Denis)
                {
                    Console.WriteLine("Poluchilosj!!");

                }
                else
                {
                    Console.WriteLine("hujovo");

                }}
            */

        }
        }
    }

