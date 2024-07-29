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

        public static int GetNumberIndex(double[] array, double number)
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
            
            bool isNumeric = TryGetUserIntNumber(out double number, "Введите число: ");

            if (isNumeric)
            {
                double maxNumber = SearchMax(array);

                int idNumber = GetNumberIndex(array, number);

                foreach (double e in array)
                {
                    Console.Write(e + " ");
                }

                Console.WriteLine($"Максимум {maxNumber}, нужное число индекс {idNumber}");
            }
            else
            {
                Console.WriteLine("До свидания!");
            }
        }

        static bool TryGetUserIntNumber(out double userNumber, string line)
        {
            userNumber = 0;
            while (true)
            {
                Console.WriteLine(line);

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    return false;
                }

                string input = Console.ReadLine()!;

                if (double.TryParse(input, out userNumber))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода.\nВведите целое число без пробелов и любых других символов.\nДля выхода из программы нажмите Esc, для повторного запуска — любую другую клавишу.");
                }
            }
        }
    }
}