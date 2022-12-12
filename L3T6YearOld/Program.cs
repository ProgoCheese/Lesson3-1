//Задача Возраст
using System;
class Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                CheckDatunm();
            }
        }

        static void CheckDatunm()
        {
            Console.WriteLine("Введите возраст");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year < 20 && year > 10 || year > 110)
            {
                Console.WriteLine("Вам " + year + " лет");
            }
            else if (year % 5 == 0)
            {
                Console.WriteLine("Вам " + year + " лет");
            }
            else if (year % 10 <= 4)
            {
                Console.WriteLine("Вам " + year + " года");
            }
            else if (year == 1)
            {
                Console.WriteLine("Вам " + year + " год");
            }
            else
            {
                Console.WriteLine("Вам " + year + " лет");
            }
        }
    }
}