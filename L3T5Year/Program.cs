///Задача Следующая дата
using System;
class Sample
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Программа рассчитывает високосный ли год.");
            Console.WriteLine("Введите год:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год невисокосный");
            }
        }
    }
}
