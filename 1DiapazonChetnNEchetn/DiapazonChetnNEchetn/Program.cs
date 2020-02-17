using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapazonChetnNEchetn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программа, которая будет считать количество четных и нечетн чисел в вашем диапазоне, также выводить их сумму

                Console.WriteLine("Введите лимит, в котором будут считаться числа: ");

            while(true)
            
            try
            {

                int limit = int.Parse(Console.ReadLine());




                int count = 0;
                while (count < limit)
                {
                    count++;
                    int value = count % 2;
                    if (value == 0)
                    {
                        Console.WriteLine("Четные числа: " + count);
                            int sum1 = count + count;
                    }
                    else
                    {
                        Console.WriteLine("Нечетные числа: " + count);
                            int sum2 = count + count;
                    }
                     
                    }
                    count++;
                    int value2 = count % 2;
                    if (value2 == 0)
                    {
                       int sum1 = count + count;
                    }
                    else
                    {
                       int sum2 = count + count;
                    }

                    Console.WriteLine("Ващ диапазон был до: " + limit);
                  //  Console.WriteLine("Сумм ваших чисел: " + sum);

                }
                catch (Exception)
            {
                Console.WriteLine("Ошибка! Введите пожалуйста целое число!");
            }


        }
    }
}
