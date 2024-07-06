using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3_1
{
    /// <summary>
    /// AM
    /// </summary>
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 6, 2, 8, 9, 12, 945, 23,4 };

            int sum = 0;
            int count = 0;

            int halfLegth = (arr.Length + arr.Length % 2) / 2;

            for (int i = 0; i < halfLegth; i++)
            {
                int a = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = a;
            }

            foreach(int e in arr)
            {
                Console.Write(e + " ");
            }
        }
    }
}