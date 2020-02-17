using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummaChetnNEchetn
{
    class Program
    {
        static void Main(string[] args)

        {

            // Считает сумму четных и нечетных чисел
            uint oddNumber= 0;
            uint evenNumver= 0;
            Console.WriteLine("Впишите начало счета: ");
            int currentValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Впишите конец диапазона: ");
            int limit =int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumver++;



                }
                else
                {
                    oddNumber++;
                }
                currentValue++;

             }
            Console.WriteLine("Количество нечетных чисел: " + evenNumver);
            Console.WriteLine("Количество четных чисел: " + oddNumber);
        }
    }
}
