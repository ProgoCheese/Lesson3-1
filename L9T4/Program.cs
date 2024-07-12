using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson3_1
{
    /// <summary>
    /// max
    /// </summary>
    class Program
    {
        public static double SearchMax(double[] array)
        {
            double max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        public static int SearchNumber(double[] array, double number)
        {
            int findedNumber = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    findedNumber = i;
                }
            }

            return findedNumber;
        }

        static void Main()
        {
            double[] array = { 1, 6, 2, 0, 53, 1, 55, 32 };

            Console.WriteLine("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            double max = SearchMax(array);

            int findedNumber = SearchNumber(array, number);

            foreach (double e in array)
            {
                Console.Write(e+" ");
            }

            Console.WriteLine($"Максимум {max}, нужное число индекс {findedNumber}");
        }
    }
}