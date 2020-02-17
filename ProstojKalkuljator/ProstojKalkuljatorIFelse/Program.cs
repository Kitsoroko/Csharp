using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProstojKalkuljatorIFelse
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Впишите первое число: ");
                string FirstValue = Console.ReadLine();
                double UsingFirstValue;
                bool first = double.TryParse(FirstValue, out UsingFirstValue);
                if (first)
                {
                    Console.WriteLine("Ваше первое число: " + UsingFirstValue);
                }
                else {
                    Console.WriteLine("Проверьте написание первого числа: " + FirstValue);
                }

                Console.WriteLine("Впишите второе число:");
                string SecondValue = Console.ReadLine();
                double UsingSecondValue;
                bool second = double.TryParse(SecondValue, out UsingSecondValue);
                if (second)
                {
                    Console.WriteLine("Ваше второе число: " + UsingSecondValue);
                }
                else
                {
                    Console.WriteLine("Проверьте написание второго числа: " + SecondValue);
                }
                Console.WriteLine("Какую хотите провести операция?( 1.+,2.-,3.*,4./ ): ");
                string dejstvije = Console.ReadLine();
                // double UsingFirstValue = Convert.ToDouble(FirstValue);
                //  double UsingSecondValue = Convert.ToDouble(SecondValue);
                int WhichOperation;
                bool Usingdejstvie = int.TryParse(dejstvije, out WhichOperation);
                if (Usingdejstvie)
                {
                    switch (WhichOperation)
                    {


                        case 1:
                            double sum = UsingFirstValue + UsingSecondValue;
                            Console.WriteLine("Сумма ваших чисел: " + sum);

                            break;

                        case 2:

                            double difference = UsingFirstValue - UsingSecondValue;
                            Console.WriteLine("Ваша разница чисел: " + difference);

                            break;
                        case 3:
                            double multi = UsingFirstValue * UsingSecondValue;
                            Console.WriteLine("Произведение ваших чисел:" + multi);
                            break;
                        case 4:
                            double division = UsingFirstValue / UsingSecondValue;
                            Console.WriteLine("Деление ваших чисел: " + division);
                            break;
                        default:
                            Console.WriteLine("Проверье написание действия! Либо знак действия, либо цифру действия!");
                            break;

                    }
                }
                else
                {
                    switch (dejstvije)
                    {


                        case "+":
                            double sum = UsingFirstValue + UsingSecondValue;
                            Console.WriteLine("Сумма ваших чисел: " + sum);

                            break;

                        case "-":

                            double difference = UsingFirstValue - UsingSecondValue;
                            Console.WriteLine("Ваша разница чисел: " + difference);

                            break;
                        case "*":
                            double multi = UsingFirstValue * UsingSecondValue;
                            Console.WriteLine("Произведение ваших чисел:" + multi);
                            break;
                        case "/":
                            double division = UsingFirstValue / UsingSecondValue;
                            Console.WriteLine("Деление ваших чисел: " + division);
                            break;
                        default:
                            Console.WriteLine("Проверье написание действия! Либо знак действия, либо цифру действия!");
                            break;
                    }

                }
            }
            
             


        }
    }
}
