using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3_1
{
    /// <summary>
    /// нод
    /// </summary>
    class Program
    {
        public static void SortArr(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (a[j] < a[j - 1])
                    {
                        int temp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = temp;
                    }
                }
            }
        }

        static void Main()
        {
            int[] a = { 2, 5, 8, 1, 32, 975, 23, 0, 42, 66 };

            SortArr(a);

            Console.WriteLine();

            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}