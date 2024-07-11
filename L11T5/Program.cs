using System;
using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            a = b + a;
            b = a - b;
            a = a - b;
        }

        //public static int[] QuickSort(int[] a, int left, int right)
        //{

        //}

        static void Main()
        {
            int[] a = { 2, 5, 8, 1, 32, 975, 23, 0, 42, 66 };

            //QuickSort(a, 0, a.Length - 1);

            Console.WriteLine();

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}