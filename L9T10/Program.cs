using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3_1
{
    /// <summary>
    /// сортировка
    /// </summary>
    class Program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 8, 9, 12, 945};

            bool isUpArr = true;
            bool isDownArr = true;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] >= arr[i - 1])
                {
                    isDownArr = false;
                }

                if (arr[i] <= arr[i - 1])
                {
                    isUpArr = false;
                }
            }

            Console.WriteLine($"массив возрастает: {isUpArr}, он убывает: {isDownArr}");
        }
    }
}