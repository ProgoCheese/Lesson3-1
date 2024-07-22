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
            
            double number = 0;
            bool isNumeric = TryGetUserIntNumber(out number, "Введите число: ");

            if (isNumeric)
            {
                double maxNumber = SearchMax(array);

                int idNumber = GetIdNumber(array, number);

                foreach (double e in array)
                {
                    Console.Write(e + " ");
                }

                Console.WriteLine($"Максимум {maxNumber}, нужное число индекс {idNumber}");
            }
        }

        static bool TryGetUserIntNumber(out double userNumber, string line)
        {
            Console.WriteLine(line);

            userNumber = 0;
            while (true)
            {
                Console.Write("Введите целое число (или нажмите Esc для выхода): ");
                string input = Console.ReadLine()!;

                // Проверка нажатия клавиши Esc
                if (string.IsNullOrEmpty(input))
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        return false;
                    }
                }

                if (double.TryParse(input, out userNumber))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода. Введите целое число без пробелов и любых других символов. Для выхода из программы нажмите Esc.");
                }
            }
        }
    }
}