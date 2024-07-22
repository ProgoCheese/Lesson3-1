namespace Lesson3_1
{
    /// <summary>
    /// таблица умножения
    /// </summary>
    class Program
    {
        public static int[,] SetMultiplicationTable(int length, int width)
        {
            int[,] array = new int[length, width];

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array[i, j] = (i + 1) * (j + 1);
                }
            }

            return array;
        }

        static void Main()
        {
            Console.WriteLine("Введите размеры таблицы умножения");

            int tableLength;
            bool isLength = TryGetUserIntNumber(out tableLength, "Введите целое число, соответствующее ширине таблице");

            int tableWidth;
            bool isWidth = TryGetUserIntNumber(out tableWidth, "Введите целое число, соответствующее высоте таблице");

            if (isLength && isLength)
            {
                int[,] array = SetMultiplicationTable(tableLength, tableWidth);

                for (int i = 0; i < tableLength; i++)
                {
                    for (int j = 0; j < tableWidth; j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }

        static bool TryGetUserIntNumber(out int userNumber, string line)
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

                if (int.TryParse(input, out userNumber))
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