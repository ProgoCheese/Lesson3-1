﻿using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static int SearchMin(int[] a, int start)
        {
            int min = a[start];
            int minId = start;

            for (int i = start; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    minId = i;
                }
            }

            return minId;
        }

        public static void SortArr(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int min = SearchMin(a, i);

                int temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
        }

        static void Main()
        {
            int[] a = {2,5,8,1,32,975,23,0,42,66 };

            SortArr(a);

            Console.WriteLine();

            foreach (int i in a)
            {
                Console.Write(i+" ");
            }
        }
    }
}