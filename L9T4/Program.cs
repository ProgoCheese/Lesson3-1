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

        public static int GetIdNumber(double[] array, double number)
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
            double[] array = [1, 6, 2, 0, 53, 1, 55, 32];

            while (true)
            {

                Console.WriteLine("Введите число: ");
                string userString = Console.ReadLine()!;
                bool isNumeric = true;

                foreach (char c in userString)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumeric = false;
                        break;
                    }
                }

                if (!isNumeric || userString == "")
                {
                    Console.WriteLine("Попробуй снова");
                }
                else
                {
                    double number = Convert.ToDouble(userString);
                    double maxNumber = SearchMax(array);

                    int idNumber = GetIdNumber(array, number);

                    foreach (double e in array)
                    {
                        Console.Write(e + " ");
                    }

                    Console.WriteLine($"Максимум {maxNumber}, нужное число индекс {idNumber}");

                    break;
                }
            }
        }
    }
}