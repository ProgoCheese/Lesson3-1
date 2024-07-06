using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3_1
{
    /// <summary>
    /// таблица умножения
    /// </summary>
    class Program
    {
        public static void SetMultiplicationTable(int[,] arr, int x)
        {
            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    arr[i, j] = (i + 1) * (j + 1);
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Введите размеры таблицы");
            int x = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[x,x];

            SetMultiplicationTable(arr, x);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}