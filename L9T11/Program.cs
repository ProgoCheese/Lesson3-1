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
            Console.WriteLine("Введите длину и ширину таблицы умножения");

            string length = Console.ReadLine()!;
            int tableLength = int.TryParse(length, out int numL) ? Convert.ToInt32(length) : 0;
         
            string width = Console.ReadLine()!;
            int tableWidth = int.TryParse(width, out int numW) ? Convert.ToInt32(width) : 0;

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
}