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

            bool isWidth = TryGetUserIntNumber(out int tableWidth, "Введите целое число, соответствующее ширине таблице: ");

            if (isWidth)
            {
                bool isLength = TryGetUserIntNumber(out int tableLength, "Введите целое число, соответствующее высоте таблице: ");

                if (isLength)
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
                else
                {
                    Console.WriteLine("До свидания!");
                }
            }
            else
            {
                Console.WriteLine("До свидания!");
            }
        }

        static bool TryGetUserIntNumber(out int userNumber, string line)
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

                if (int.TryParse(input, out userNumber))
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