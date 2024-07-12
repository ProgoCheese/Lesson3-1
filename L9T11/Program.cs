using System.Data.SqlTypes;
using System;

namespace Lesson3_1
{
    /// <summary>
    /// таблица умножения
    /// </summary>
    class Program
    {
        public static int[,] SetMultiplicationTable(int x, int y)
        {
            int[,] array = new int[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                }
            }

            return array;
        }

        static void Main()
        {
            Console.WriteLine("Введите размеры таблицы умножения");
            var length = Console.ReadLine();
            int tableLength = !String.IsNullOrEmpty(length) ? Convert.ToInt32(length) : 0;
            var width = Console.ReadLine();
            int tableWidth = !String.IsNullOrEmpty(width) ? Convert.ToInt32(width) : 0;

            int[,] array = SetMultiplicationTable(tableLength, tableWidth);

            for (int i = 0; i < tableLength; i++)
            {
                for (int j = 0; j < tableWidth; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}