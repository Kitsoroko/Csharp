using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.KonvertStroki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //команда для перевода русской клавиатур
            // parse/tryparse
            // Конвертация строки

            string str = "5";
            Console.WriteLine("Do konvertacii: " +str);
            int a = int.Parse(str);
            Console.WriteLine("Posle"+a);
            str = "2as";
            Console.WriteLine("Do popitki konvertacii: "+ str);
            try
            {
                int b = int.Parse(str);
            }
            catch
            {
                Console.WriteLine("Ошибка при конвертации, ибо инт не может быть 2as");
            }


            str = "2";
            Console.WriteLine("Do popitki konvertacii: " + str);
            try
            {
                int c = int.Parse(str);
                Console.WriteLine("Uspewno, rezuljtat: " +str);
            }
            catch (Exception) // owibka
            {
                Console.WriteLine("Ошибка при конвертации, ибо инт не может быть 2as");
            }
            //         RABOTA S TRAPARSE
            Console.WriteLine("\n\t\t\t Rabota s TryParse");
            str = "1";
            Console.WriteLine("\nDo konverta:" + str);
            int d;
            int.TryParse(str, out d);
            Console.WriteLine("Rezultat posle konverta:" +d);
            str = "23 adaddada";
            Console.WriteLine("\nDo konverta:" +str);
            int z;
            int.TryParse(str, out z);
            Console.WriteLine("Rezultat z = "+z);
            bool result = int.TryParse(str, out z);
            if (result)
            {
                Console.WriteLine("Uspewno poluchilosj");
            }
            else {
                Console.WriteLine("Grustno, ne poluchilosy");
            }
            {
                Console.WriteLine("\n\n Давай поиграем? Напиши значение, я попробую конвертировать!:");
                Console.WriteLine("Сейчас попробуем parse метод. Напиши мне символы просто цифры или цифры и буквы:");
                str = Console.ReadLine();
                Console.WriteLine("Ты ввел:" + str);
                
                try
                {
                    int perevod = int.Parse(str);
                    Console.WriteLine("Получилось перевести, ибо ты перевел только цифры:" + perevod);
                }
                catch
                {
                    Console.WriteLine("Ошибка при конвертации, ибо инт не может быть "+str);
                }
                Console.WriteLine("Теперь мы попробуем метод tryparse.\n Из этого следует, тебе стоит написать опчть цифру и т.д. Сам се знаешь");
                str = Console.ReadLine();
                Console.WriteLine("Ты ввел:" +str);
                int perevodtry;
                bool resultTry = int.TryParse(str, out perevodtry);
                if (resultTry)
                {
                    Console.WriteLine("Успешно получилось перевести в инт цифорки:" +resultTry);
                }
                else 
                {
                    Console.WriteLine("Грустно, не получилось. Нужны только цифры, а не:" +str);
                }
            }
        }
    }
}
