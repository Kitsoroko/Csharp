using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamoProverka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //команда для перевода русской клавиатур
            // Программа для вычисления средней арифметической 2-ух чисел.
            // Программа для вычисления для решение суммы и произв. 3-ех чисел
            // Программа конвертер валют евро\лат
            /*Console.WriteLine("Доброго времени суток! Чего желаете?\n (1)Средняя арифметическая\n (2)Сумма и произведение 3чисел\n (3) Конвертер\n (4) Выйти.");
            
            string nachalo = Console.ReadLine();
            int vibor;
            vibor = Convert.ToInt32(nachalo);
            */
            {
                Console.WriteLine("\t\t\t\tCредняя арифметическая 2-ух чисел");
                Console.WriteLine("\n Впишите первое число: ");
                string a = Console.ReadLine();
                Console.WriteLine("Введите второе число: ");
                string b = Console.ReadLine();
                double a1, b1;
                bool result = double.TryParse(a, out a1);
                if (result)
                {
                    Console.WriteLine("Ваше первое число =" + a1);
                }
                else
                {
                    Console.WriteLine("Проверьте написание первого числа. Там должно находится только цифры!");
                }
                bool result2 = double.TryParse(b, out b1);

                if (result2)
                {
                    Console.WriteLine("Ваше второе число: " + b1);
                }
                else
                {
                    Console.WriteLine("Проверьте написание второго числа!");
                }
                double c = (a1 + b1) / 2;
                Console.WriteLine("Средняя арифметическая ваших чисел: " + c);
            }
            {
                Console.WriteLine("\n\n\n\t\t\t\tПрограмма для вычисления суммы и произведения из 3 чисел");
                Console.WriteLine("\n\nПожалуйста, введите ваше первое число: ");
                string a = Console.ReadLine();
                Console.WriteLine("Пожалуйста, введите второе число: ");
                string b = Console.ReadLine();
                Console.WriteLine("Пожалуйста, введите третье число: ");
                string c = Console.ReadLine();
                double a1, b1, c1;
                bool result = double.TryParse(a, out a1);
                if (result)
                {
                    Console.WriteLine("Ваше первое число =" + a1);
                }
                else
                {
                    Console.WriteLine("Проверьте написание первого числа. Там должно находится только цифры!");
                }
                bool result2 = double.TryParse(b, out b1);

                if (result2)
                {
                    Console.WriteLine("Ваше второе число: " + b1);
                }
                else
                {
                    Console.WriteLine("Проверьте написание второго числа!");
                }
                bool result3 = double.TryParse(c, out c1);
                if (result3)
                {
                    Console.WriteLine("Ваше третье число =" + c1);
                }
                else
                {
                    Console.WriteLine("Проверьте написание третьего числа. Там должно находится только цифры!");
                }
                double sum = a1 + b1 + c1;
                double umn = a1 * b1 * c1;
                Console.WriteLine("Сумма ваших чисел: " + sum + "\nПроизведение ваших чисел: " + umn);

            }
            { 
            Console.WriteLine("\n\n\n\t\t\t\tКонвертер валют из Латов в Евро");
            Console.WriteLine("\n\n Впишите вашу сумму, которую вы хотите перевести из латов в евро, по курсу 0.72:1. Ваша сумма: ");
            string a = Console.ReadLine();
                double a1;
                bool result = double.TryParse(a, out a1);
                if (result)
                {
                    Console.WriteLine("Ваша введенная сумма: " + a1);
                }
                else
                {
                    Console.WriteLine("Вы что-то написали не правильно. " +a + "Не забывайте про запятую х,хх");
                }
                double b1;
                b1 = a1 * 1.38;
                Console.WriteLine("Ваши латы в евро: " + b1);
            }
            
            
        }
    }
}
