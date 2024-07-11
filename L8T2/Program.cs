namespace Lesson3_1
{
    /// <summary>
    /// Макс. строка
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку: ");
            string userString = Console.ReadLine()!;

            int maxString = 0;
            int currentMax = 1;

            for (int i = 1; i < userString.Length; i++)
            {
                char currentChar = userString[i];
                char previousChar = userString[i - 1];

                if (previousChar == currentChar)
                {
                    currentMax++;
                }
                else
                {
                    if (maxString < currentMax)
                    {
                        maxString = currentMax;
                        currentMax = 1;
                    }
                }
            }

            Console.WriteLine($"Максимальная подстрока {maxString}");
        }
    }
}